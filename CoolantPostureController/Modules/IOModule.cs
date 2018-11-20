using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using CoolantPostureController.DataPoll;

namespace CoolantPostureController.Modules
{
    public enum IOCMDIdx : ushort
    { 
    
    }


    public class IOModule : IModule
    {
        protected const int bufferlength = 10;
        protected ushort[] buffer = new ushort[bufferlength];

        private IOCMDIdx[] UpdateList = 
        {
        };

        private IOModule()
        { }


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
            ushort val = 0;


            if (_devicedatapoll != null)
            {

                foreach (IOCMDIdx item in UpdateList)
                {
                    val = _devicedatapoll.ReadSingleHoldingRegisters((ushort)item);

                    if (buffer[(ushort)item] != val)
                        DoDataChanged((ushort)item);

                    buffer[(ushort)item] = val;
                }
            }
        }


        private IDeviceDataPoll _devicedatapoll = null;
        public IDeviceDataPoll DeviceDataPoll
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
            get { return 0; }        
        }

    }
}
