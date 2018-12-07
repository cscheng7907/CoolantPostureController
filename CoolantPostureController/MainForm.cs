using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using ModbusTcpTerminal;
using ServerSuperIO.Modbus;
using CoolantPostureController.DataPoll;
using CoolantPostureController.Modules;
using System.Runtime.InteropServices;
using System.IO;
using ServerSuperIO.Modbus.Device;
using CoolantPostureController.UICtrls;
using ComCtrls;

namespace CoolantPostureController
{
    public partial class MainForm : Form
    {
        private const string FontfileName = @"HardDisk\MSYH.ttf";

#if WindowsCE
        private const string PortName = "COM2";
#else
        private const string PortName = "COM3";
#endif
        private const int mouselast = 3000;//ms
        private const string password_EnterWinCE = "111";
        private const string password_Enterterminal = "222";


        private const string password_Diagnose = "666";//诊断界面密码
        private SerialPort port = null;
        private System.Drawing.Point bigviewLocation;
        private System.Drawing.Size bigviewsize;

        public MainForm()
        {
            InitializeComponent();
        }

        private SerialPort GetSerialPort()
        {
            if (port == null)
            {
                try
                {
                    port = new SerialPort(PortName);
                    // configure serial port
                    port.BaudRate = 115200;//9600;
                    port.DataBits = 8;
                    port.Parity = Parity.None;// .Even;
                    port.StopBits = StopBits.One;
                    port.Open();
                    port.ReadTimeout = 5000;
                    port.WriteTimeout = 1000;

                }
                catch (Exception)
                {
                    MessageBox.Show("当前端口（" + PortName + "）已被占用，请关闭应用。");
                    Application.Exit();
                }
            }


            return port;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //drv
            DriverDeviceDataPoll DataPoll = new DriverDeviceDataPoll();
            IStreamResource StreamRes = new SerialPortAdapter(GetSerialPort());
            IModbusMaster ModbusMaster = ModbusMasterFactory.CreateRtu();


            DataPoll.StreamRes = StreamRes;
            DataPoll.ModbusMaster = ModbusMaster;

            DriverModule.GetInstance().DeviceDataPoll = DataPoll;

            //io
            IODeviceDataPoll ioDataPoll = new IODeviceDataPoll();

            ioDataPoll.StreamRes = StreamRes;// new SerialPortAdapter(GetSerialPort());
            ioDataPoll.ModbusMaster = ModbusMaster;// ModbusMasterFactory.CreateRtu();

            IOModule.GetInstance().DeviceDataPoll = ioDataPoll;


            if (isFontExists())
                LoadFont();

            bigviewLocation = new Point(0, this.panel_Title.Height);
            bigviewsize = new Size(this.Width, this.Height - this.panel_Title.Height);

            TId2AngleConfigure.GetInstance().Load();

            timer1.Enabled = true;
            ViewMap();


        }

        #region testing
        private void ViewMap()
        {
#if CSTEST
            Terminal ter = new Terminal();
            ter.Dock = DockStyle.Fill;
            this.panel_body.Controls.Add(ter);
#else
            //timer1_Tick(this, null);

            //imageLabel_Diagnose_Click(this, null);
            timer1_Tick(this, null);
            imageLabel_MAC_Click(this, null);
#endif
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        //自动运行
        //private void DoControl()
        //{
        //    DriverModule.GetInstance().GotoPos(
        //        TId2AngleConfigure.GetInstance().GetAngle(
        //        IOModule.GetInstance().ToolNum));
        //}



        private void DoTitleUpdate()
        {
            DateTime dt = DateTime.Now;
            // lb_date.Text = string.Format("{0:00}-{1:00}-{2:00} {3:00}:{4:00}:{5:00}", dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);
            this.label_Date.Text = string.Format("{0:0000}-{1:00}-{2:00}", dt.Year, dt.Month, dt.Day);//"日期：2015-02-12";

            this.label_Time.Text = string.Format("{0:00} : {1:00} : {2:00}", dt.Hour, dt.Minute, dt.Second);//"时间：12 : 11 : 18";

            this.label_ErrNo.Visible = DriverModule.GetInstance().Error;
            if (this.label_ErrNo.Visible)
                this.label_ErrNo.Text = DriverModule.GetInstance().ErrorNo.ToString();
        }

        private void DoIOSignal()
        {
            IOModule.GetInstance().Error = DriverModule.GetInstance().Error;

            IOModule.GetInstance().Ready =
               !DriverModule.GetInstance().Error &&
               DriverModule.GetInstance().Homed &&
               DriverModule.GetInstance().Inpos &&
               IOModule.GetInstance().LatheReady;
        }

        #region 加载字体
#if WindowsCE
        //新增字体
        [DllImport("coredll", EntryPoint = "AddFontResource")]
        private static extern int AddFontResource([In, MarshalAs(UnmanagedType.BStr)]string fontSource);

        [DllImport("coredll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
#endif

        private bool isFontExists()
        {
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (System.Drawing.FontFamily family in fonts.Families)
            {
                if (family.Name == "微软雅黑")
                    return true;
            }
            return false;
        }

        private void LoadFont()
        {
#if WindowsCE
            if (!isFontExists())
            {
                if (File.Exists(FontfileName))
                {
                    int installFont = AddFontResource(FontfileName);
                    SendMessage((IntPtr)0xffff, 0x001d, IntPtr.Zero, IntPtr.Zero);
                }
            }
#endif
        }
        #endregion

        #region PageView vars
        private PageViewDiagnose pvDiagnose = null;
        private PageViewMAC pvMAC = null;
        private PageViewEdit pvEdit = null;
        private Terminal pvTerminal = null;


        public void Create_pvMAC()
        {
            if (pvMAC == null)
            {
                pvMAC = new PageViewMAC();
                pvMAC.Location = bigviewLocation;
                pvMAC.Size = bigviewsize;
                pvMAC.Enabled = false;
                pvMAC.OnPageChange += new OnDataChangedEventHandler(DoPageChange);
                this.Controls.Add(this.pvMAC);
            }
        }

        private const ushort PageNo_Edit = 0;
        private const ushort PageNo_Diagnose = 1;

        private void DoPageChange(ushort index)
        {
            switch (index)
            {
                case PageNo_Edit:
                    imageLabel_Edit_Click(this, null);
                    break;
                case PageNo_Diagnose:
                    imageLabel_Diagnose_Click(this, null);
                    break;
                default:
                    break;
            }

        }

        private void imageLabel_MAC_Click(object sender, EventArgs e)
        {
            Create_pvMAC();
            pvMAC.DoEnter();
        }

        public void Create_pvDiagnose()
        {
            if (pvDiagnose == null)
            {
                pvDiagnose = new PageViewDiagnose();
                pvDiagnose.Location = bigviewLocation;
                pvDiagnose.Size = bigviewsize;
                pvDiagnose.Enabled = false;
                this.Controls.Add(this.pvDiagnose);
            }
        }

        private void imageLabel_Diagnose_Click(object sender, EventArgs e)
        {
#if UNPASSWORD
            Create_pvDiagnose();
            pvDiagnose.DoEnter();
#else
            KeypadForm f = KeypadForm.GetKeypadForm("", KeypadMode.password);
            if (f.ShowDialog() == DialogResult.OK)
            {
                // 安装设定
                if (f.KeyText == password_Diagnose)
                {
                    Create_pvDiagnose();
                    pvDiagnose.DoEnter();
                }
            }
#endif
        }

        public void Create_pvEdit()
        {
            if (pvEdit == null)
            {
                pvEdit = new PageViewEdit();
                pvEdit.Location = bigviewLocation;
                pvEdit.Size = bigviewsize;
                pvEdit.Enabled = false;
                this.Controls.Add(this.pvEdit);
            }
        }

        private void imageLabel_Edit_Click(object sender, EventArgs e)
        {
            Create_pvEdit();
            pvEdit.DoEnter();
        }


        private void Create_pvTerminal()
        {
            if (pvTerminal == null)
            {
                pvTerminal = new Terminal();
                pvTerminal.Location = bigviewLocation;
                pvTerminal.Size = bigviewsize;
                pvTerminal.Enabled = false;
                this.Controls.Add(this.pvTerminal);

            }
        }

        private void imageLabel_Terminal_Click(object sender, EventArgs e)
        {
            Create_pvTerminal();
            pvTerminal.DoEnter();
            //Terminal ter = new Terminal();
            //ter.Dock = DockStyle.Fill;
            //this.panel_body.Controls.Add(ter);
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            DriverModule.GetInstance().DoRefresh();
            IOModule.GetInstance().DoRefresh();

            DoTitleUpdate();
            DoIOSignal();
        }


        #region MouseEvent & password
        private Point _MP;
        DateTime MouseDownTime = DateTime.Now;
        private void panel_Head_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //else 
            if (e.Button == MouseButtons.Left)
            {
                _MP.X = e.X;
                _MP.Y = e.Y;
                MouseDownTime = DateTime.Now;
            }
        }
        private void panel_Head_MouseMove(object sender, MouseEventArgs e)
        {
#if WindowsCE
#else
            if (e.Button == MouseButtons.Left)
            {
                Top = MousePosition.Y - _MP.Y;
                Left = MousePosition.X - _MP.X;
            }
#endif
        }
        private void panel_Head_MouseUp(object sender, MouseEventArgs e)
        {
            DateTime MouseUpTime = DateTime.Now;

            TimeSpan ts = (TimeSpan)(MouseUpTime - MouseDownTime);

            if (ts.TotalMilliseconds >= mouselast)
            {
                KeypadForm f = KeypadForm.GetKeypadForm("", KeypadMode.password);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    //退出程序，进入wince 
                    if (f.KeyText == password_EnterWinCE)
                    {
                        System.Diagnostics.Process.Start("explorer.exe", "");
                        //System.Diagnostics.Process.Start("\\NORFlash\\001\\COPY.bat", "");
                        Application.DoEvents();
                        Application.Exit();
                    }
                    else if (f.KeyText == password_Enterterminal)
                    {
                        imageLabel_Terminal_Click(this, null);
                    }
                    //else if (f.KeyText == password_Update) //软件升级
                    //{
                    //    if (File.Exists("\\HardDisk\\AdvaMACSysUpdater.exe"))
                    //    {
                    //        System.Diagnostics.Process.Start("\\HardDisk\\AdvaMACSysUpdater.exe", "");

                    //        Application.DoEvents();
                    //        Application.Exit();
                    //    }
                    //    else
                    //        if (File.Exists("\\USB Hard Disk\\AdvaMACSysUpdater.exe"))
                    //        {
                    //            System.Diagnostics.Process.Start("\\USB Hard Disk\\AdvaMACSysUpdater.exe", "");

                    //            Application.DoEvents();
                    //            Application.Exit();
                    //        }

                    //}
#if WindowsCE
#else
                    //else if (f.KeyText == password_Test) //test
                    //{
                    //    if (_VirtualSetForm == null)
                    //        _VirtualSetForm = new VirtualSetForm();

                    //    _VirtualSetForm.Show();
                    //}
#endif
                    //else if (f.KeyText == password_Reset) //系统数据复位
                    //{
                    //    CDataPool.GetDataPoolObject().Reset();

                    //    if (WarnErrOper != null)
                    //        WarnErrOper.Reset();

                    //    if (historyOper != null)
                    //        historyOper.Reset();
                    //}
                    //else if (f.KeyText == password_Backup_History)//历史记录备份
                    //{
                    //    FileCpyForm.GetFileCpyForm().StartCopy();
                    //}
                }
            }
        }
        #endregion

        private void panel_Title_DoubleClick(object sender, EventArgs e)
        {
#if WindowsCE
#else





#endif
        }


    }
}