using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using CoolantPostureController.Modules;

namespace CoolantPostureController
{
    public partial class Terminal : UIControlbase
    {
        private Dictionary<DriverCMDIdx, ushort> InitList = new Dictionary<DriverCMDIdx, ushort> 
        {
            {DriverCMDIdx.drv_idx_17_xifen, 10},//细分设置 10 4000 pu/rev	   
            
            {DriverCMDIdx.drv_idx_49_HomeMode, 3},//回零模式 3反限位模式

            {DriverCMDIdx.drv_idx_67_X0_define, 3},//X0功能=3：反限位
            {DriverCMDIdx.drv_idx_68_X1_define, 2},//X1功能=2：正限位
            {DriverCMDIdx.drv_idx_69_X2_define, 9},//X2功能=9：急停

            {DriverCMDIdx.drv_idx_76_Y0_define, 1}//Y0功能 =1：报警信号
        };

        public Terminal()
        {
            InitializeComponent();
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            textBox_Val.Text = DriverModule.GetInstance().GetPara((DriverCMDIdx)Convert.ToInt16(textBox_Idx.Text)).ToString();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            DriverModule.GetInstance().SetPara((DriverCMDIdx)Convert.ToInt16(textBox_Idx.Text), Convert.ToUInt16(textBox_Val.Text));
        }

        private void button_Init_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<DriverCMDIdx, ushort> item in InitList)
            {
                DriverModule.GetInstance().SetPara(item.Key, item.Value);
            }
        }

        private void Terminal_Click(object sender, EventArgs e)
        {

        }

        private void button_Locate_Click(object sender, EventArgs e)
        {
            try
            {
                DriverModule.GetInstance().GotoPos(Convert.ToDouble(textBox_pos.Text));

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            DriverModule.GetInstance().DoPause();
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            DriverModule.GetInstance().DoHome();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            DriverModule.GetInstance().DoReset();
        }

        private void button_pos_Click(object sender, EventArgs e)
        {
            DriverModule.GetInstance().DoRefresh();

            label_Pos.Text = DriverModule.GetInstance().Position.ToString("0.0");

            checkBox_en.Checked = DriverModule.GetInstance().Enable;
            checkBox_err.Checked = DriverModule.GetInstance().Error;
            checkBox_homed.Checked = DriverModule.GetInstance().Homed;
            checkBox_inpos.Checked = DriverModule.GetInstance().Inpos;


            IOModule.GetInstance().DoRefresh();
            label_TN.Text = IOModule.GetInstance().ToolNum.ToString();
            checkBox_Ready.Checked = IOModule.GetInstance().LatheReady;
            checkBox_Inc.Checked = IOModule.GetInstance().BtnInc;
            checkBox_Dec.Checked = IOModule.GetInstance().BtnDec;

            //label_out.Text = (IOModule.GetInstance().GetOutput(0) ? "1 " : "0 ") +
            //     (IOModule.GetInstance().GetOutput(1) ? "1 " : "0 ") +
            //     (IOModule.GetInstance().GetOutput(2) ? "1 " : "0 ") +
            //     (IOModule.GetInstance().GetOutput(3) ? "1 " : "0 ");
            checklock = true;
            try
            {
                checkBox_ot0.Checked = IOModule.GetInstance().GetOutput(0);
                checkBox_ot1.Checked = IOModule.GetInstance().GetOutput(1);
                checkBox_ot2.Checked = IOModule.GetInstance().GetOutput(2);
                checkBox_ot3.Checked = IOModule.GetInstance().GetOutput(3);

            }
            finally
            {
                checklock = false;
            }


        }


        private bool checklock = false;
        private void checkBox_ot0_CheckStateChanged(object sender, EventArgs e)
        {

            if (sender is CheckBox && !checklock)
            {
                CheckBox c = (CheckBox)sender;

                IOModule.GetInstance().SetOutput(Convert.ToInt32(c.Tag), c.Checked);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DoExit();
        }
    }
}
