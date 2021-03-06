﻿using System;
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
    public partial class PageViewEdit : UIControlbase
    {
        private List<EditCell> EditCellList = new List<EditCell>();
        private const int EditCellListCount = 32;

        private const double StepLength_Large = 5;
        private const double StepLength_Small = 0.5;


        private double StepLength = StepLength_Small;

        private int selectIndex = -1;

        private ImagesContaner BackButtonImage = null;//按钮背景图
        private ImagesContaner PgBackButtonImage = null;//按钮背景图
        private ImagesContaner PgForeButtonImage = null;//按钮背景图
        private ImagesContaner JogModeButtonImage = null;//按钮背景图
        private ImagesContaner JogButtonImage = null;//按钮背景图
        private ImagesContaner SetButtonImage = null;//按钮背景图

        #region 布局
        private Color textColor = Color.Black;//字体颜色
        private Font currentFont = new Font("微软雅黑", 18F, FontStyle.Regular);//IO标签字体
        private Font BtnFont = new Font("微软雅黑", 18F, FontStyle.Regular);//IO标签字体
        private int IOMarginTop = 15;//90;//第一行IO标签与顶端方向间距
        private int IOMarginLeft = 20;//第一列IO标签与左端方向间距
        private int IOWidth = 145;//210;//IO标签宽度
        private int IOHeight = 35;//35;//IO标签高度
        private int IOSpacingX = 16;//IO标签之间X方向间距
        private int IOSpacingY = 10;//2;//IO标签之间Y方向间距

        private int TextMarginLeft = 10;// 15;
        private int TextMarginTop = 5;

        private int ButtonWidth = 60;
        private int ButtonHeight = 23;
        private int ButtonMarginTop = 570;
        private int ButtonSpacingX = 40;
        private int ButtonSpacingY = 5;
        #endregion

        public PageViewEdit()
        {
            InitializeComponent();

            //按钮 返回
            BackButtonImage = new ImagesContaner();
            BackButtonImage.DNImg = CoolantPostureControlerRes.ellipse_up;//.Set_down;
            BackButtonImage.UPImg = CoolantPostureControlerRes.ellipse_dn;//.Set_up;
            BackButtonImage.UPImgDisaable = CoolantPostureControlerRes.ellipse_dis;// Set_disable;
            BackButtonImage.DNImgDisable = CoolantPostureControlerRes.ellipse_dis;// Set_disable;

            button_back.IMGContainer = BackButtonImage;
            button_back.Font = BtnFont;
            button_back.MouseUp += new MouseEventHandler(this.ExitButton_Click);
            //end 按钮 返回 

            //翻页按钮

            PgBackButtonImage = new ImagesContaner();
            PgBackButtonImage.DNImg = CoolantPostureControlerRes.Pg_back_dn;//.Set_down;
            PgBackButtonImage.UPImg = CoolantPostureControlerRes.Pg_back_dis;//.Set_up;
            PgBackButtonImage.UPImgDisaable = CoolantPostureControlerRes.Pg_back_dis;// Set_disable;
            PgBackButtonImage.DNImgDisable = CoolantPostureControlerRes.Pg_back_dis;// Set_disable;

            imageButton_Pgback.IMGContainer = PgBackButtonImage;
            imageButton_Pgback.Font = BtnFont;
            imageButton_Pgback.Text = string.Empty;
            imageButton_Pgback.BringToFront();

            PgForeButtonImage = new ImagesContaner();
            PgForeButtonImage.DNImg = CoolantPostureControlerRes.Pg_fore_dn;//.Set_down;
            PgForeButtonImage.UPImg = CoolantPostureControlerRes.Pg_fore_dis;//.Set_up;
            PgForeButtonImage.UPImgDisaable = CoolantPostureControlerRes.Pg_fore_dis;// Set_disable;
            PgForeButtonImage.DNImgDisable = CoolantPostureControlerRes.Pg_fore_dis;// Set_disable;

            imageButton_PgFore.IMGContainer = PgForeButtonImage;
            imageButton_PgFore.Font = BtnFont;
            imageButton_PgFore.Text = string.Empty;
            imageButton_PgFore.BringToFront();

            //end 翻页按钮


            //JogMode按钮 
            JogModeButtonImage = new ImagesContaner();
            JogModeButtonImage.DNImg = CoolantPostureControlerRes.rabbit_jog;//.Set_down;
            JogModeButtonImage.UPImg = CoolantPostureControlerRes.turtle_jog;//.Set_up;
            JogModeButtonImage.UPImgDisaable = CoolantPostureControlerRes.turtle_jog;// Set_disable;
            JogModeButtonImage.DNImgDisable = CoolantPostureControlerRes.rabbit_jog;// Set_disable;


            imageButton_JogMode.IMGContainer = JogModeButtonImage;
            imageButton_JogMode.Font = BtnFont;
            imageButton_JogMode.MouseUp += new MouseEventHandler(this.JogModeButton_Click);
            //end JogMode按钮

            //Jog+-
            JogButtonImage = new ImagesContaner();
            JogButtonImage.DNImg = CoolantPostureControlerRes.JogBtn_up;//.Set_down;
            JogButtonImage.UPImg = CoolantPostureControlerRes.JogBtn_dn;//.Set_up;
            JogButtonImage.UPImgDisaable = CoolantPostureControlerRes.JogBtn_dn;// Set_disable;
            JogButtonImage.DNImgDisable = CoolantPostureControlerRes.JogBtn_up;// Set_disable;

            imageButton_Inc.IMGContainer = JogButtonImage;
            imageButton_Dec.IMGContainer = JogButtonImage;

            imageButton_Inc.Font = BtnFont;
            imageButton_Dec.Font = BtnFont;
            //end Jog+-

            //set
            SetButtonImage = new ImagesContaner();
            SetButtonImage.DNImg = CoolantPostureControlerRes.Btn_dn;//.Set_down;
            SetButtonImage.UPImg = CoolantPostureControlerRes.Btn_up;//.Set_up;
            SetButtonImage.UPImgDisaable = CoolantPostureControlerRes.btn_dis;// Set_disable;
            SetButtonImage.DNImgDisable = CoolantPostureControlerRes.btn_dis;// Set_disable;

            imageButton_Set.IMGContainer = SetButtonImage;

            imageButton_Set.Font = BtnFont;
            //end set

            label_cap.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            label_Pos.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            label_ToolNum.Font = new Font("微软雅黑", 18F, FontStyle.Bold);

            //EditCell
            this.SuspendLayout();
            this.panel_body.SuspendLayout();

            for (int i = 0; i < EditCellListCount; i++)
            {
                EditCell cell = new EditCell();
                EditCellList.Add(cell);

                cell.Size = new Size(IOWidth, IOHeight);
                cell.Location = new Point((i / 8) * (IOWidth + IOSpacingX), IOMarginTop + (i % 8) * (IOHeight + IOSpacingY));
                cell.Font = currentFont;
                cell.ForeColor = textColor;
                cell.KeyNum = i;
                cell.KeyValue = 0;
                cell.Tag = i;
                cell.Click += new EventHandler(DoCellClick);
                this.panel_body.Controls.Add(cell);
            }









            this.panel_body.ResumeLayout(false);
            this.ResumeLayout(false);
            BindDataChange();
        }

        public override void DoEnter()
        {
            base.DoEnter();

            DoRefreshPage();

            DoRefresh();
        }
        public override void DoReEnter()
        {
            base.DoReEnter();

            DoRefreshPage();
            DoRefresh();
        }

        protected override void DoExit()
        { base.DoExit(); }


        private void BindDataChange()
        {
            DriverModule.GetInstance().OnDataChanged += new OnDataChangedEventHandler(DoDrvDataChange);
            IOModule.GetInstance().OnDataChanged += new OnDataChangedEventHandler(DoIODdataChange);
        }




        #region data change

        public void DoRefresh()
        {
            UpdateToolNum();
            UpdateAng();

            //DoRun();
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
                        //DoRun();
                        break;
                    //case IOCMDIdx.io_inc:
                    //    DriverModule.GetInstance().GotoPos(
                    //       DriverModule.GetInstance().Position + AngIncStep);

                    //    break;
                    //case IOCMDIdx.io_dec:
                    //    DriverModule.GetInstance().GotoPos(
                    //       DriverModule.GetInstance().Position - AngIncStep);

                    //    break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region data
        private int PageIdx = 0;


        private void DoRefreshPage()
        {
            for (int i = 0; i < EditCellListCount; i++)
            {
                EditCellList[i].KeyNum = PageIdx * EditCellListCount + i;
                EditCellList[i].KeyValue =
                    TId2AngleConfigure.GetInstance().GetAngle(EditCellList[i].KeyNum);
            }

            DoCellClick(EditCellList[0], null);
        }


        #endregion

        #region Clicks
        private void DoCellClick(object sender, EventArgs e)
        {
            if (sender is EditCell)
            {
                EditCell ce = (EditCell)sender;

                //for (int i = 0; i < EditCellListCount; i++)
                //{
                //    EditCellList[i].Checked = (EditCellList[i] == ce);
                //    if (EditCellList[i].Checked)
                //        selectIndex = i;
                //}
                if (selectIndex >= 0)
                {
                    EditCellList[selectIndex].Checked = false;
                }
                ce.Checked = true;
                selectIndex = Convert.ToInt32(ce.Tag);


                linkLabel_Edit.Text = ce.KeyValue.ToString("0.0");
            }
        }

        private void ExitButton_Click(object sender, MouseEventArgs e)
        {
            this.DoExit();

        }
        private void imageButton_Inc_Click(object sender, EventArgs e)
        {
            DriverModule.GetInstance().GotoPos(
                 DriverModule.GetInstance().Position + StepLength
              );
        }

        private void imageButton_Dec_Click(object sender, EventArgs e)
        {
            DriverModule.GetInstance().GotoPos(
                 DriverModule.GetInstance().Position - StepLength
              );
        }

        private void imageButton_Set_Click(object sender, EventArgs e)
        {
            if (selectIndex >= 0)
            {
                EditCell selcell = EditCellList[selectIndex];
                // TId2AngleConfigure.GetInstance().SetAngle (

                selcell.KeyValue = DriverModule.GetInstance().Position;
                linkLabel_Edit.Text = selcell.KeyValue.ToString("0.0");

                TId2AngleConfigure.GetInstance().SetAngle(
                    selcell.KeyNum,
                    selcell.KeyValue);

                TId2AngleConfigure.GetInstance().Save();
                //,
            }
        }

        private void imageButton_Pgback_Click(object sender, EventArgs e)
        {
            if (PageIdx > 0)
            {
                PageIdx--;
                DoRefreshPage();
            }
        }

        private void imageButton_PgFore_Click(object sender, EventArgs e)
        {
            if (PageIdx < 1)
            {
                PageIdx++;
                DoRefreshPage();
            }
        }

        private void linkLabel_Edit_Click(object sender, EventArgs e)
        {
            KeypadForm f = KeypadForm.GetKeypadForm("", KeypadMode.Normal);
            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    double input = Convert.ToDouble(f.KeyText);
                    if (selectIndex >= 0)
                    {
                        EditCell selcell = EditCellList[selectIndex];


                        selcell.KeyValue = input;
                        linkLabel_Edit.Text = input.ToString("0.0");

                        TId2AngleConfigure.GetInstance().SetAngle(
                           selcell.KeyNum,
                           selcell.KeyValue);

                        TId2AngleConfigure.GetInstance().Save();
                    }
                }
                catch (Exception)
                {


                }


            }
        }

        private void JogModeButton_Click(object sender, EventArgs e)
        {
            if (sender is ImageButton)
            {
                ImageButton ib = (ImageButton)sender;

                StepLength = (ib.Checked) ?
                    StepLength_Large :
                    StepLength_Small;

            }
        }
        #endregion
    }
}
