using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using CoolantPostureController.DataPoll;

namespace CoolantPostureController.Modules
{
    public enum IOCMDIdx : ushort
    {
        io_input0 = 0,
        io_input1 = 1,
        io_input2 = 2,
        io_input3 = 3,

        io_input4 = 4,
        io_input5 = 5,
        io_input6 = 6,
        io_input7 = 7,

        io_input8 = 8,
        io_input9 = 9,
        io_input10 = 10,

        io_output0 = 11,
        io_output1 = 12,
        io_output2 = 13,
        io_output3 = 14,

        io_toolnum = 15,
        io_inc = 16,
        io_dec = 17,
        io_ready = 18
    }


    public class IOModule : IModule
    {
        protected const int inputbufferlength = 11;
        protected bool[] inputbuffer = new bool[inputbufferlength];
        protected bool[] inputbuffer_bk = new bool[inputbufferlength];

        protected const int outputbufferlength = 4;
        protected bool[] outputbuffer = new bool[outputbufferlength];
        protected bool[] outputbuffer_bk = new bool[outputbufferlength];

        private IOModule()
        { }

        private ushort Addr_Coils_Start = 0;
        private bool trigerMode_riseedge = true;
        private enum cmdIdx
        {
            ciToolNum0 = 0,
            ciToolNum1 = 1,
            ciToolNum2 = 2,
            ciToolNum3 = 3,
            ciToolNum4 = 4,
            ciToolNum5 = 5,
            ciInc = 6,
            ciDec = 7,
            ciReady = 8
        }

        private string[] InputCaptionList = new string[] 
        {
            "#0 刀具号0",
            "#1 刀具号1",
            "#2 刀具号2",
            "#3 刀具号3",
            "#4 刀具号4",
            "#5 刀具号5",
            "#6 补偿+",
            "#7 补偿-",
            "#8 机床就绪",
            "#9 未定义",
            "#10 未定义"
        };

        private string[] OuputCaptionList = new string[] 
        {
            "#0 已就绪",
            "#1 报警",
            "#2 未定义",
            "#3 未定义"
        };


        private static IOModule _obj_IOModule = null;
        public static IOModule GetInstance()
        {
            if (_obj_IOModule == null)
                _obj_IOModule = new IOModule();

            return _obj_IOModule;
        }


        private bool _connected = false;
        public bool Connected { get { return _connected; } }

        public void DoRefresh()
        {
            bool[] inputval = new bool[inputbufferlength];
            bool[] outputval = new bool[outputbufferlength];

            bool toolchange = false;

            if (_devicedatapoll != null)
            {
                //input
                inputval = _devicedatapoll.ReadInputs(Addr_Coils_Start, inputbufferlength);

                //if (buffer[(ushort)item] != val)
                //    DoDataChanged((ushort)item);

                if (inputval != null && inputval.Length >= inputbuffer.Length)
                {
                    Buffer.BlockCopy(inputbuffer, 0, inputbuffer_bk, 0, inputbufferlength);

                    Buffer.BlockCopy(inputval, 0, inputbuffer, 0, inputbufferlength);


                    for (int i = 0; i < inputbuffer.Length; i++)
                    {
                        if ((i >= (int)cmdIdx.ciToolNum0) && (i <= (int)cmdIdx.ciToolNum5) && (inputval[i] != inputbuffer_bk[i]))
                        {
                            DoDataChanged((ushort)i);

                            toolchange = true;
                        }

                        if ((i == (int)cmdIdx.ciInc) && (inputval[i] != inputbuffer_bk[i]) && (inputval[i] == trigerMode_riseedge))
                            DoDataChanged((ushort)IOCMDIdx.io_inc);

                        if ((i == (int)cmdIdx.ciDec) && (inputval[i] != inputbuffer_bk[i]) && (inputval[i] == trigerMode_riseedge))
                            DoDataChanged((ushort)IOCMDIdx.io_dec);

                        if ((i == (int)cmdIdx.ciReady) && (inputval[i] != inputbuffer_bk[i]))
                            DoDataChanged((ushort)IOCMDIdx.io_ready);
                    }

                    if (toolchange) DoDataChanged((ushort)IOCMDIdx.io_toolnum);

                    //Buffer.BlockCopy(inputval, 0, inputbuffer, 0, inputbufferlength);
                }


                //output

                outputval = _devicedatapoll.ReadCoils(Addr_Coils_Start, outputbufferlength);
                if (outputval != null && outputval.Length >= outputbuffer.Length)
                {
                    Buffer.BlockCopy(outputbuffer, 0, outputbuffer_bk, 0, outputbufferlength);
                    Buffer.BlockCopy(outputval, 0, outputbuffer, 0, outputbufferlength);

                    for (int i = 0; i < outputbuffer.Length; i++)
                    {
                        //if ((i >= (int)cmdIdx.ciToolNum0) && (i <= (int)cmdIdx.ciToolNum5) && (inputval[i] != inputbuffer[i]))
                        //    toolchange = true;

                        //if ((i == (int)cmdIdx.ciInc) && (inputval[i] != inputbuffer[i]) && (inputval[i] == trigerMode_riseedge))
                        //    DoDataChanged((ushort)IOCMDIdx.io_inc);

                        //if ((i == (int)cmdIdx.ciDec) && (inputval[i] != inputbuffer[i]) && (inputval[i] == trigerMode_riseedge))
                        //    DoDataChanged((ushort)IOCMDIdx.io_dec);

                        //if ((i == (int)cmdIdx.ciReady) && (inputval[i] != inputbuffer[i]))
                        //    DoDataChanged((ushort)IOCMDIdx.io_ready);
                        if (outputval[i] != outputbuffer_bk[i])
                            DoDataChanged((ushort)((ushort)IOCMDIdx.io_output0 + i));
                    }

                    //if (toolchange) DoDataChanged((ushort)IOCMDIdx.io_toolnum);

                    //Buffer.BlockCopy(outputval, 0, outputbuffer, 0, outputbufferlength);
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


        protected void DoDataChanged(ushort idx)
        {
            if (OnDataChanged != null)
                OnDataChanged(idx);
        }


        //todo by cs
        public int ToolNum
        {
            get
            {
                int v = 0;
                for (int i = 0; i <= (int)cmdIdx.ciToolNum5; i++)
                {
                    v += ((inputbuffer[i]) ? 1 : 0) << i;
                }

                return v;
            }
        }

        public bool BtnInc
        { get { return inputbuffer[(int)cmdIdx.ciInc]; } }

        public bool BtnDec
        { get { return inputbuffer[(int)cmdIdx.ciDec]; } }

        public bool LatheReady
        {
            get { return inputbuffer[(int)cmdIdx.ciReady]; }
        }

        private bool _ready = false;
        public bool Ready
        {
            get { return _ready; }
            set
            {
                if (_ready != value)
                {
                    _ready = value;

                    SetOutput((int)IOCMDIdx.io_output0, _ready);
                }
            }
        }

        private bool _error = false;
        public bool Error
        {
            get { return _error; }
            set
            {
                if (_error != value)
                {
                    _error = value;

                    SetOutput((int)IOCMDIdx.io_output1, _error);
                }

            }

        }



        public bool GetInput(int index)
        {
            if (index >= 0 && index < inputbufferlength)
                return inputbuffer[index];
            else
                return false;
        }

        public bool GetOutput(int index)
        {
            if (index >= 0 && index < outputbufferlength)
                return outputbuffer[index];
            else
                return false;
        }

        public void SetOutput(int index, bool value)
        {
            if (index >= 0 && index < outputbufferlength)
            {
                _devicedatapoll.WriteSingleCoil((ushort)index, value);
            }

        }





        public string GetInputCaption(int index)
        {
            if (index >= 0 && index < InputCaptionList.Length)
                return InputCaptionList[index];
            else
                return "#  未定义";
        }




    }
}
