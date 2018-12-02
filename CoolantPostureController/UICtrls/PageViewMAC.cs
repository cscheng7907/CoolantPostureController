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
        private ComCtrls.SimpleImagesContaner BtnImage = null;//IO标签背景图
        private double AngIncStep = 0.5;
        private bool isRunning = false;


        public PageViewMAC()
        {
            InitializeComponent();

            BtnImage = new SimpleImagesContaner();
            BtnImage.BackImg = CoolantPostureControlerRes.Btn_up;
            BtnImage.ImgDisable = CoolantPostureControlerRes.btn_dis;
            BtnImage.CheckedBackImg = CoolantPostureControlerRes.Btn_up;

            imageLabel_Edit.IMGContainer =
                imageLabel_Edit.IMGContainer =
                imageLabel_Diagnose.IMGContainer =
                imageLabel_Home.IMGContainer =
                BtnImage;
        }

        public override void DoEnter()
        {

            base.DoEnter();
            DoRefresh();
        }

        protected override void DoExit()
        {
            base.DoExit();
        }
        #region data change

        private void DoRefresh()
        {
            UpdateToolNum();
            UpdateAng();

            DoRun();
        }


        private void UpdateToolNum()
        {
            label_ToolNum.Text = IOModule.GetInstance().ToolNum.ToString();
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

        private void imageLabel_Reset_Click(object sender, EventArgs e)
        {
            DriverModule.GetInstance().DoReset();
        }

        private void imageLabel_Home_Click(object sender, EventArgs e)
        {
            DriverModule.GetInstance().DoHome();
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
