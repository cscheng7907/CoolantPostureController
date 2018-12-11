using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ComCtrls;
using CoolantPostureController.Modules;

namespace CoolantPostureController.UICtrls
{
    public partial class PageViewDiagnose : UIControlbase
    {
        private List<ImageLabel> DrvIOLableList = null;//电机输入点 列表
        private List<ImageLabel> IOLableList = null;//IO 输入点 列表

        private List<ImageLabel> DrvIOButtonList = null;//电机输出点 列表
        private List<ImageLabel> IOButtonList = null;//IO 输出点 列表


        private ComCtrls.SimpleImagesContaner InputImage = null;//IO标签背景图
        private ComCtrls.SimpleImagesContaner OutputImage = null;//IO标签背景图


        private ImagesContaner BackButtonImage = null;//按钮背景图
        private const int DrvIOLableCount = 7;
        private const int IOLableCount = 11;

        private const int DrvIOButtonCount = 3;
        private const int IOButtonCount = 4;


        #region 布局
        private Color textColor = Color.Black;//字体颜色
        private Font currentFont = new Font("微软雅黑", 16F, FontStyle.Regular);//IO标签字体
        private Font BtnFont = new Font("微软雅黑", 18F, FontStyle.Regular);//IO标签字体


        private int IOMarginTop = 10;//90;//第一行IO标签与顶端方向间距
        private int IOMarginLeft = 20;//第一列IO标签与左端方向间距
        private int IOWidth = 160;//210;//IO标签宽度
        private int IOHeight = 34;//35;//IO标签高度
        private int IOSpacingX = 20;//IO标签之间X方向间距
        private int IOSpacingY = 10;//2;//IO标签之间Y方向间距

        private int TextMarginLeft = 10;// 15;
        private int TextMarginTop = 5;

        private int ButtonWidth = 60;
        private int ButtonHeight = 23;
        private int ButtonMarginTop = 570;
        private int ButtonSpacingX = 40;
        private int ButtonSpacingY = 5;
        #endregion


        public PageViewDiagnose()
        {
            InitializeComponent();

            DrvIOLableList = new List<ImageLabel>();
            IOLableList = new List<ImageLabel>();

            DrvIOButtonList = new List<ImageLabel>();
            IOButtonList = new List<ImageLabel>();

            InputImage = new SimpleImagesContaner();
            InputImage.BackImg = CoolantPostureControlerRes.green_off;
            InputImage.ImgDisable = CoolantPostureControlerRes.gray_off;
            InputImage.CheckedBackImg = CoolantPostureControlerRes.green_on;

            OutputImage = new SimpleImagesContaner();
            OutputImage.BackImg = CoolantPostureControlerRes.red_off;
            OutputImage.ImgDisable = CoolantPostureControlerRes.gray_off;
            OutputImage.CheckedBackImg = CoolantPostureControlerRes.red_on;


            BackButtonImage = new ImagesContaner();
            BackButtonImage.DNImg = CoolantPostureControlerRes.ellipse_up;//.Set_down;
            BackButtonImage.UPImg = CoolantPostureControlerRes.ellipse_dn;//.Set_up;
            BackButtonImage.UPImgDisaable = CoolantPostureControlerRes.ellipse_dis;// Set_disable;
            BackButtonImage.DNImgDisable = CoolantPostureControlerRes.ellipse_dis;// Set_disable;


            //input
            for (int i = 0; i < DrvIOLableCount; i++)
            {
                ImageLabel cylinder = new ImageLabel();
                DrvIOLableList.Add(cylinder);
            }

            for (int i = 0; i < IOLableCount; i++)
            {
                ImageLabel cylinder = new ImageLabel();
                IOLableList.Add(cylinder);
            }

            //output
            for (int i = 0; i < IOButtonCount; i++)
            {
                ImageLabel cylinder = new ImageLabel();
                IOButtonList.Add(cylinder);
            }

            for (int i = 0; i < DrvIOButtonCount; i++)
            {
                ImageLabel cylinder = new ImageLabel();
                DrvIOButtonList.Add(cylinder);
            }

            this.SuspendLayout();
            this.panel_Drv.SuspendLayout();
            this.panel_IO.SuspendLayout();

            this.panel_IO.BackColor = 
                this.panel_Drv.BackColor = 
                this.BackColor;


            //input
            for (int i = 0; i < DrvIOLableCount; i++)
            {
                ImageLabel cylinder = DrvIOLableList[i];
                cylinder.Size = new Size(IOWidth, IOHeight);
                cylinder.Location = new Point((i / 8) * (IOWidth + IOSpacingX), IOMarginTop + (i % 8) * (IOHeight + IOSpacingY));
                cylinder.IMGContainer = InputImage;
                cylinder.Font = currentFont;
                cylinder.ForeColor = textColor;
                cylinder.TransParent = true;
                cylinder.TextX = TextMarginLeft;
                cylinder.TextY = TextMarginTop;
                cylinder.Text = "电机 输入#" + i.ToString();
                cylinder.BackColor = this.panel_Drv.BackColor; 
                this.panel_Drv.Controls.Add(cylinder);
            }


            for (int i = 0; i < IOLableCount; i++)
            {
                ImageLabel cylinder = IOLableList[i];
                cylinder.Size = new Size(IOWidth, IOHeight);
                cylinder.Location = new Point((i / 8) * (IOWidth + IOSpacingX), IOMarginTop + (i % 8) * (IOHeight + IOSpacingY));
                cylinder.IMGContainer = InputImage;
                cylinder.Font = currentFont;
                cylinder.ForeColor = textColor;
                cylinder.TransParent = true;
                cylinder.TextX = TextMarginLeft;
                cylinder.TextY = TextMarginTop;
                cylinder.Text = "开关 输入#" + i.ToString();
                cylinder.BackColor = this.panel_IO.BackColor;
                this.panel_IO.Controls.Add(cylinder);
            }

            //output
            for (int i = 0; i < DrvIOButtonCount; i++)
            {
                int ib = i + 8;

                ImageLabel cylinder = DrvIOButtonList[i];
                cylinder.Size = new Size(IOWidth, IOHeight);
                cylinder.Location =
                    new Point((ib / 8) * (IOWidth + IOSpacingX), IOMarginTop + (ib % 8) * (IOHeight + IOSpacingY));
                cylinder.IMGContainer = OutputImage;
                cylinder.Font = currentFont;
                cylinder.ForeColor = textColor;
                cylinder.TransParent = true;
                cylinder.TextX = TextMarginLeft;
                cylinder.TextY = TextMarginTop;
                cylinder.Text = "电机 输出#" + i.ToString();
                cylinder.BackColor = this.panel_Drv.BackColor; 

                this.panel_Drv.Controls.Add(cylinder);
            }


            for (int i = 0; i < IOButtonCount; i++)
            {
                int ib = i + 12;
                ImageLabel cylinder = IOButtonList[i];
                cylinder.Size = new Size(IOWidth, IOHeight);
                cylinder.Location =
                    new Point((ib / 8) * (IOWidth + IOSpacingX), IOMarginTop + (ib % 8) * (IOHeight + IOSpacingY));
                cylinder.IMGContainer = OutputImage;
                cylinder.Font = currentFont;
                cylinder.ForeColor = textColor;
                cylinder.TransParent = true;
                cylinder.TextX = TextMarginLeft;
                cylinder.TextY = TextMarginTop;
                cylinder.Text = "开关 输出#" + i.ToString();

                cylinder.Tag = i;
                cylinder.Click += new EventHandler(ioButton_Click);
                cylinder.BackColor = this.panel_IO.BackColor;

                this.panel_IO.Controls.Add(cylinder);
            }


            button33.IMGContainer = BackButtonImage;
           // button33.Toggle = true;
            button33.Font = BtnFont;
            //button33.ForeColor = Color.White;//textColor;
            this.label_Diagnose.Font = new Font("微软雅黑", 18F, FontStyle.Bold);



            this.panel_Drv.ResumeLayout(false);
            this.panel_IO.ResumeLayout(false);
            this.ResumeLayout(false);

            BindDataChange();
        }

        private void BindDataChange()
        {
            DriverModule.GetInstance().OnDataChanged += new OnDataChangedEventHandler(drvdataChange);
            IOModule.GetInstance().OnDataChanged += new OnDataChangedEventHandler(iodataChange);
        }


        public override void DoEnter()
        {
            base.DoEnter();

            DoRefresh();
        }

        public override void DoReEnter()
        {
            base.DoReEnter();

            DoRefresh();
        }


        protected override void DoExit()
        {
            base.DoExit();
        }

        private void ExitButton_Click(object sender, MouseEventArgs e)
        {
            this.DoExit();
        }

        private void DoRefresh()
        {
            UpdateDrvInput();
            UpdateDrvOutput();
            UpdateIOInput();
            UpdateIOOutput();
        }

        private void UpdateDrvInput()
        {
            ushort s = DriverModule.GetInstance().GetPara(DriverCMDIdx.drv_idx_8_InputPortState);

            for (int i = 0; i < DrvIOLableCount; i++)
            {
                DrvIOLableList[i].Checked = (s & (1 << i)) != 0;
            }

        }

        private void UpdateDrvOutput()
        {
            ushort s = DriverModule.GetInstance().GetPara(DriverCMDIdx.drv_idx_9_OutputPortState);

            for (int i = 0; i < DrvIOButtonCount; i++)
            {
                DrvIOButtonList[i].Checked = (s & (1 << i)) != 0;
            }

        }

        private void UpdateIOInput()
        {
            for (int i = 0; i < IOLableCount; i++)
            {
                IOLableList[i].Checked = IOModule.GetInstance().GetInput(i);
            }
        }

        private void UpdateIOOutput()
        {
            for (int i = 0; i < IOButtonCount; i++)
            {
                IOButtonList[i].Checked = IOModule.GetInstance().GetOutput(i);
            }
        }



        private void drvdataChange(ushort Idx)
        {
            if (this.Enabled)
            {
                switch ((DriverCMDIdx)Idx)
                {
                    case DriverCMDIdx.drv_idx_8_InputPortState:
                        UpdateDrvInput();

                        break;
                    case DriverCMDIdx.drv_idx_9_OutputPortState:
                        UpdateDrvOutput();

                        break;
                    default:
                        break;
                }

            }

        }
        private void iodataChange(ushort Idx)
        {

            if (this.Enabled)
            {
                switch ((IOCMDIdx)Idx)
                {
                    case IOCMDIdx.io_input0:
                    case IOCMDIdx.io_input1:
                    case IOCMDIdx.io_input2:
                    case IOCMDIdx.io_input3:

                    case IOCMDIdx.io_input4:
                    case IOCMDIdx.io_input5:
                    case IOCMDIdx.io_input6:
                    case IOCMDIdx.io_input7:

                    case IOCMDIdx.io_input8:
                    case IOCMDIdx.io_input9:
                    case IOCMDIdx.io_input10:
                        IOLableList[Idx].Checked = IOModule.GetInstance().GetInput(Idx);

                        break;
                    case IOCMDIdx.io_output0:
                    case IOCMDIdx.io_output1:
                    case IOCMDIdx.io_output2:
                    case IOCMDIdx.io_output3:
                        IOButtonList[Idx - (ushort)IOCMDIdx.io_output0].Checked = IOModule.GetInstance().GetOutput(Idx - (ushort)IOCMDIdx.io_output0);

                        break;
                    default:
                        break;





                }

            }
        }

        private void ioButton_Click(object sender, EventArgs e)
        {
            if (sender is ImageLabel)
            {
                ImageLabel op = (ImageLabel)sender;

                IOModule.GetInstance().SetOutput((int)op.Tag, !op.Checked);
            }

        }

        private void PageViewDiagnose_Click(object sender, EventArgs e)
        {
#if WindowsCE

#else

            DriverModule.GetInstance().DoRefresh();
            IOModule.GetInstance().DoRefresh();

            DoRefresh();


#endif
        }
    }
}
