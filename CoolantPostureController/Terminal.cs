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
    public partial class Terminal : UserControl
    {
        private Dictionary<DriverCMDIdx, ushort> InitList = new Dictionary<DriverCMDIdx, ushort> 
        {
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
    }
}
