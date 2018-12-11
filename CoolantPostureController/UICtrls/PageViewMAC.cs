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
    public partial class PageViewMAC : UIControlbase
    {
        private ComCtrls.ImagesContaner BtnImage = null;//IO标签背景图
        private ComCtrls.SimpleImagesContaner LabelImage = null;//IO标签背景图

        private Font currentFont = new Font("微软雅黑", 60F, FontStyle.Bold);//IO标签字体
        private Font BtnFont = new Font("微软雅黑", 18F, FontStyle.Regular);//IO标签字体

        private double AngIncStep = 0.5;
        private bool isRunning = false;


        public PageViewMAC()
        {
            InitializeComponent();

            BtnImage = new ImagesContaner();
            BtnImage.DNImg = CoolantPostureControlerRes.Btn_up;
            BtnImage.UPImg = CoolantPostureControlerRes.Btn_dn;
            BtnImage.UPImgDisaable = CoolantPostureControlerRes.btn_dis;
            BtnImage.DNImgDisable = CoolantPostureControlerRes.btn_dis;

            LabelImage = new SimpleImagesContaner();
            LabelImage.BackImg = CoolantPostureControlerRes.Btn_dn;
            LabelImage.ImgDisable = CoolantPostureControlerRes.btn_dis;
            LabelImage.CheckedBackImg = CoolantPostureControlerRes.Btn_up;

            imageLabel_Edit.IMGContainer =
                imageLabel_Diagnose.IMGContainer =
                LabelImage;

            imageLabel_Home.IMGContainer =
                imageLabel_Reset.IMGContainer =
                imageLabel_Start.IMGContainer =
                BtnImage;

            //font
            label_ToolNum.Font =
                label_Pos.Font =
                currentFont;

            imageLabel_Edit.Font =
                imageLabel_Diagnose.Font =
                imageLabel_Home.Font =
                imageLabel_Reset.Font =
                imageLabel_Start.Font =
                BtnFont;

            BindDataChange();
        }


        private void BindDataChange()
        {
            DriverModule.GetInstance().OnDataChanged += new OnDataChangedEventHandler(DoDrvDataChange);
            IOModule.GetInstance().OnDataChanged += new OnDataChangedEventHandler(DoIODdataChange);
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
            DoRun();
        }

        protected override void DoExit()
        {
            base.DoExit();
        }
        #region data change

        public void DoRefresh()
        {
            UpdateToolNum();
            UpdateAng();
        }


        private void UpdateToolNum()
        {
            label_ToolNum.Text = "# " + IOModule.GetInstance().ToolNum.ToString();
        }

        private void UpdateAng()
        {
            label_Pos.Text = DriverModule.GetInstance().Position.ToString("0.0") + "°";
        }


        private void DoDrvDataChange(ushort Idx)
        {
            if (this.Enabled)
            {
                switch ((DriverCMDIdx)Idx)
                {
                    case DriverCMDIdx.drv_idx_10_PosHigh:
                    case DriverCMDIdx.drv_idx_11_PosLow:
                        UpdateAng();
                        break;
                    default:
                        break;
                }
            }
        }


        private void DoIODdataChange(ushort Idx)
        {
            if (this.Enabled)
            {
                switch ((IOCMDIdx)Idx)
                {
                    case IOCMDIdx.io_toolnum:
                        UpdateToolNum();
                        DoRun();
                        break;
                    case IOCMDIdx.io_inc:
                        DriverModule.GetInstance().GotoPos(
                           DriverModule.GetInstance().Position + AngIncStep);

                        break;
                    case IOCMDIdx.io_dec:
                        DriverModule.GetInstance().GotoPos(
                           DriverModule.GetInstance().Position - AngIncStep);

                        break;
                    default:
                        break;
                }
            }
        }

        #endregion
        #region click

        private void imageLabel_Click(object sender, EventArgs e)
        {
            if (sender is ImageLabel)
                DoDataChanged(ushort.Parse((((ImageLabel)sender).Tag.ToString())));
        }


        private void imageLabel_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void imageLabel_Reset_Click(object sender, EventArgs e)
        {
            DriverModule.GetInstance().DoReset();
        }

        private void imageLabel_Home_Click(object sender, EventArgs e)
        {
            DriverModule.GetInstance().DoHome();
        }

        private void imageLabel_Start_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            imageLabel_Start.Text = isRunning ? "停止" : "启动";

            if (isRunning)
                DoRun();
        }
        #endregion

        public event OnDataChangedEventHandler OnPageChange = null;


        protected void DoDataChanged(ushort idx)
        {
            if (OnPageChange != null)
                OnPageChange((ushort)idx);
        }


        private void DoRun()
        {
            if (isRunning)
            {
                DriverModule.GetInstance().GotoPos(
                 TId2AngleConfigure.GetInstance().GetAngle(
                     IOModule.GetInstance().ToolNum)
                     );
            }

        }






    }
}
