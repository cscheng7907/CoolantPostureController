using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using CoolantPostureController.DataPoll;

namespace CoolantPostureController.Modules
{
    public enum DriverCMDIdx : ushort
    {
        //1、触摸屏需要监视的参数	
        #region 触摸屏监视
        //0x0004        电机运动状态	0禁止 1 运动 RO	状态栏
        drv_idx_4_DriverState = 0x0004,

        //0x0006	当前错误码	Ro	状态栏
        drv_idx_6_ErrorNo = 0x0006,

        //0x0007	状态标记位		
        //    Bit0:到位		
        //    Bit1：回过原点了		
        //    Bit3:有报警		
        //    Bit 4:能使		
        drv_idx_7_Signal = 0x0007,

        //0x0008	输入端口状态 Bit0~bit6	Ro	诊断
        drv_idx_8_InputPortState = 0x0008,

        //0x0009	输出端子状态 Bit0~bit2	Ro	诊断
        drv_idx_9_OutputPortState = 0x0009,

        //√0x000A	当前位置高位	Ro	监控
        drv_idx_10_PosHigh = 0x000A,

        //√0x000B	当前位置低位	Ro	监控
        drv_idx_11_PosLow = 0x000B,

        //√0x000C	当前速度	Ro	监控
        drv_idx_12_Velosity = 0x000C,
        #endregion

        //0x0011	10 4000 pu/rev	细分设置  
        drv_idx_17_xifen = 0x0011,

        //2、触摸屏需要设置的参数
        #region 触摸屏设置的参数
        //0x0020	起始速度2~300r/min	5	参数
        drv_idx_32_StartVelosity = 0x0020,

        //0x0021	加速时间0~2000ms	100	参数
        drv_idx_33_AccTime = 0x0021,

        //0x0022	减速时间0~2000ms	100	参数
        drv_idx_34_DecTime = 0x0022,

        //0x0023	最大速度-3k~3k	60	参数
        drv_idx_35_MaxVelosity = 0x0023,

        //√0x0024	总脉冲数高位	
        drv_idx_36_TotalPulseHigh = 0x0024,

        //√0x0025	总脉冲数低位	
        drv_idx_37_TotalPulseLow = 0x0025,

        //√0x0027	启动命令
        //Bit0-1:01位置模式 
        //bit2:1绝对位置
        //=5	wo	命令
        drv_idx_39_StartCMD = 0x0027,

        //√0x0028	Bit0：正常停止
        //Bit1：急停	WO	命令        
        drv_idx_40_PauseCMD = 0x0028,

        //√0x0029	能使 =1	WO？	命令
        drv_idx_41_Enable = 0x0029,

        //0x002A	报警消除 =1	WO	命令
        drv_idx_42_ClearError = 0x002A,

        //0x002B	=2保存所有参数设置到EEPROM	WO	命令
        drv_idx_43_SaveAll = 0x002B,

        //0x002C	当前位置清零 =1	WO	命令
        drv_idx_44_ZeroPos = 0x002C,
        #endregion

        //3、回零参数
        #region 回零参数
        //0x0030	回零能使 =1	RO？	命令
        drv_idx_48_HomeEnable = 0x0030,

        //0x0031	回零模式 3反限位模式	RW 需要修改	预设
        drv_idx_49_HomeMode = 0x0031,

        //0x0032	回零速度 5~3000	RW 120	参数
        drv_idx_50_HomeVelosity = 0x0032,

        //0x0033	回零查询速度 5~300	RW 60	
        drv_idx_51_HomeSearchVelosity = 0x0033,

        //0x0034	回零加减速时间 30~2000	RW 100	参数
        drv_idx_52_HomeAccDecTime = 0x0034,

        //0x0035	原点正向补偿 0~65535	RW 0	
        drv_idx_53_HomePosComp = 0x0035,

        //0x0036	原点反向补偿 0~65535	RW 0	
        drv_idx_54_HomePosComp = 0x0036,
        #endregion


        //4、IO定义参数	
        #region IO定义
        //0x0040	输入取反	0	
        drv_idx_64_InputInverse = 0x0040,

        //0x0043	X0功能=3：反限位		预设
        drv_idx_67_X0_define = 0x0043,

        //0x0044	X1功能=2：正限位		预设
        drv_idx_68_X1_define = 0x0044,

        //0x0045	X2功能=9：急停		预设
        drv_idx_69_X2_define = 0x0045,

        //0x0046		
        drv_idx_70_X3_define = 0x0046,

        //0x0047	
        drv_idx_71_X4_define = 0x0047,

        //0x0048	
        drv_idx_72_X5_define = 0x0048,

        //0x0049	
        drv_idx_73_X6_define = 0x0049,

        //0x004B	输出取反	0	
        drv_idx_75_OutputInverse = 0x004B,

        //√0x004C	Y0功能 =1：报警信号		预设
        drv_idx_76_Y0_define = 0x004C,

        //0x004D	Y1
        drv_idx_77_Y1_define = 0x004D,

        //0x004E	Y2		
        drv_idx_78_Y2_define = 0x004E
        #endregion

    }



    public class DriverModule : IModule
    {
        protected const double posScale = 4000.0 / 360.0;

        protected const int bufferlength = 80;
        protected ushort[] buffer = new ushort[bufferlength];
        protected ushort[] buffer_bk = new ushort[bufferlength];


        private DriverCMDIdx[] UpdateList = 
        {
        DriverCMDIdx.drv_idx_4_DriverState ,
        DriverCMDIdx.drv_idx_6_ErrorNo ,
        DriverCMDIdx.drv_idx_7_Signal ,
        DriverCMDIdx.drv_idx_8_InputPortState ,
        DriverCMDIdx.drv_idx_9_OutputPortState ,
        DriverCMDIdx.drv_idx_10_PosHigh ,
        DriverCMDIdx.drv_idx_11_PosLow ,
        DriverCMDIdx.drv_idx_12_Velosity 
                
        };

        private DriverModule()
        { }


        private static DriverModule _obj_DriverModule = null;
        public static DriverModule GetInstance()
        {
            if (_obj_DriverModule == null)
                _obj_DriverModule = new DriverModule();

            return _obj_DriverModule;
        }


        #region Generization
        //private bool _connected = false;
        public bool Connected
        {
            get
            {
                return (_devicedatapoll != null) ? _devicedatapoll.Connected : false;//_connected;
            }
        }

        public void DoRefresh()
        {
            ushort val = 0;


            if (_devicedatapoll != null)
            {

                foreach (DriverCMDIdx item in UpdateList)
                {
                    val = _devicedatapoll.ReadSingleHoldingRegisters((ushort)item);

                    buffer_bk[(ushort)item] = buffer[(ushort)item];

                    buffer[(ushort)item] = val;

                    if (buffer[(ushort)item] != buffer_bk[(ushort)item])
                        DoDataChanged(item);
                }
            }
        }


        private DeviceDataPollbase _devicedatapoll = null;
        public DeviceDataPollbase DeviceDataPoll
        {
            set
            {
                if (_devicedatapoll != value)
                    _devicedatapoll = value;
            }
        }

        public event OnDataChangedEventHandler OnDataChanged = null;


        protected void DoDataChanged(DriverCMDIdx idx)
        {
            if (OnDataChanged != null)
                OnDataChanged((ushort)idx);
        }

        #endregion

        #region Funs
        public bool Homed
        {
            get
            {
                //bit1
                return (buffer[(ushort)DriverCMDIdx.drv_idx_7_Signal] & 0x0002) != 0;


            }

        }

        public bool Inpos
        {
            get
            {
                //bit1
                return (buffer[(ushort)DriverCMDIdx.drv_idx_7_Signal] & 0x0001) != 0;
            }
        }

        public bool Error
        {
            get
            {
                //bit1
                return (buffer[(ushort)DriverCMDIdx.drv_idx_7_Signal] & 0x0008) != 0;
            }
        }

        public bool Enable
        {
            get
            {
                //bit1
                return (buffer[(ushort)DriverCMDIdx.drv_idx_7_Signal] & 0x0010) == 0;
            }
        }


        //单位 度
        public double Position
        {
            get
            {
                int pos = buffer[(ushort)DriverCMDIdx.drv_idx_10_PosHigh];
                pos = pos << 16;
                pos += buffer[(ushort)DriverCMDIdx.drv_idx_11_PosLow];

                return pos / posScale;
            }
            //set {

            //}
        }

        public double Velosity
        {
            get { return buffer[(ushort)DriverCMDIdx.drv_idx_12_Velosity]; }
        }

        public int ErrorNo
        {
            get { return buffer[(ushort)DriverCMDIdx.drv_idx_6_ErrorNo]; }
        }



        public void DoHome()
        {
            if (_devicedatapoll != null)
            {
                //_devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_48_HomeEnable, 0);

                _devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_48_HomeEnable, 1);
            }

        }

        public void DoReset()
        {
            if (_devicedatapoll != null)
            {
                if (Error)
                {
                    _devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_42_ClearError, 0);

                    _devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_42_ClearError, 1);
                }

                if (!Enable)
                {
                    _devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_41_Enable, 0);

                    _devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_41_Enable, 1);
                }

                if (!Inpos)
                {
                    _devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_40_PauseCMD, 0);

                    _devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_40_PauseCMD, 1);
                }

            }

        }

        public void GotoPos(double pos)
        {
            int pospulse = 0;

            if (_devicedatapoll != null)
            {
                pospulse = Convert.ToInt32(pos * posScale);

                _devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_37_TotalPulseLow, (ushort)(pospulse & 0x0000FFFF));

                _devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_36_TotalPulseHigh, (ushort)((pospulse & 0xFFFF0000) >> 16));

                //_devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_39_StartCMD, 0);
                //System.Threading.Thread.Sleep(80);
                _devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_39_StartCMD, 5);
            }
        }

        public void DoPause()
        {
            if (_devicedatapoll != null)
            {
                _devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_40_PauseCMD, 0);
                //_devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_40_PauseCMD, 1);
            }
        }

        public void DoEmg()
        {
            if (_devicedatapoll != null)
            {
                //_devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_40_PauseCMD, 0);
                _devicedatapoll.WriteSingleRegister((ushort)DriverCMDIdx.drv_idx_40_PauseCMD, 1);
            }
        }
        #endregion

        #region ParaRW
        public ushort GetPara(DriverCMDIdx idx)
        {
            if (_devicedatapoll != null)
            {
                return _devicedatapoll.ReadSingleHoldingRegisters((ushort)idx);
            }
            else
                return 0;
        }


        public void SetPara(DriverCMDIdx idx, ushort value)
        {
            if (_devicedatapoll != null)
            {
                _devicedatapoll.WriteSingleRegister((ushort)idx, value);
            }
        }
        #endregion

    }
}
