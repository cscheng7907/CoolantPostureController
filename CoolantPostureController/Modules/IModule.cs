using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoolantPostureController.DataPoll;

namespace CoolantPostureController.Modules
{
    interface IModule
    {
        bool Connected { get; }

        void DoRefresh();

        DeviceDataPollbase DeviceDataPoll { set; }

        event OnDataChangedEventHandler OnDataChanged;
    }

    public delegate void OnDataChangedEventHandler(ushort Idx);
}
