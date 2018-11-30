using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoolantPostureController.DataPoll
{
    public abstract class DeviceDataPollbase
    {
        public virtual ushort ReadSingleHoldingRegisters(ushort startAddress) { return 0; }

        public virtual void WriteSingleRegister(ushort startAddress, ushort value) { }

        public virtual bool[] ReadCoils(ushort startAddress, ushort length) { return null; }
        public virtual void WriteSingleCoil(ushort startAddress, bool value) { }


        public virtual bool[] ReadInputs(ushort startAddress, ushort length) { return null; }
    }
}
