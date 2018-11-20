using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoolantPostureController.DataPoll
{
    public interface IDeviceDataPoll
    {
        ushort ReadSingleHoldingRegisters(ushort startAddress);

        void WriteSingleRegister(ushort startAddress, ushort value);
    }
}
