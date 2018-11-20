﻿using ServerSuperIO.Modbus.Common;
using ServerSuperIO.Modbus.Data;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;

namespace ServerSuperIO.Modbus.Message
{
	internal class WriteSingleCoilRequestResponse : AbstractModbusMessageWithData<RegisterCollection>, IModbusRequest
    {
        public WriteSingleCoilRequestResponse()
        {
			
        }

        public WriteSingleCoilRequestResponse(byte slaveAddress, ushort startAddress, bool coilState)
            : base(slaveAddress, Modbus.WriteSingleCoil)
        {
            StartAddress = startAddress;
            Data = new RegisterCollection(coilState ? Modbus.CoilOn : Modbus.CoilOff);
        }

        public override int MinimumFrameSize
        {
            get { return 6; }
        }

        public ushort StartAddress
        {
            get { return MessageImpl.StartAddress.Value; }
            set { MessageImpl.StartAddress = value; }
        }

        public override string ToString()
        {
            Debug.Assert(Data != null, "Argument Data cannot be null.");
            Debug.Assert(Data.Count() == 1, "Data should have a count of 1.");

            //string msg = $"Write single coil {(Data.First() == Modbus.CoilOn ? 1 : 0)} at address {StartAddress}.";
                      string msg = "Write single coil "+(Data.First() == Modbus.CoilOn ? 1 : 0).ToString ()+" at address "+StartAddress.ToString ()+".";
  return msg;
        }

        public void ValidateResponse(IModbusMessage response)
        {
            var typedResponse = (WriteSingleCoilRequestResponse)response;

            if (StartAddress != typedResponse.StartAddress)
            {
                //by cs 
                //string msg = $"Unexpected start address in response. Expected {StartAddress}, received {typedResponse.StartAddress}.";
                //throw new IOException(msg);
          return ;
            }

            if (Data.First() != typedResponse.Data.First())
            {
                //by cs 
                //string msg = $"Unexpected data in response. Expected {Data.First()}, received {typedResponse.Data.First()}.";
                //throw new IOException(msg);
         return ;
            }
        }

        protected override void InitializeUnique(byte[] frame)
        {
            StartAddress = (ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(frame, 2));
            Data = new RegisterCollection(frame.Slice(4, 2).ToArray());
        }
    }
}
