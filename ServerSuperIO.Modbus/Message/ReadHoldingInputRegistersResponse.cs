﻿using System;
using System.Linq;
using ServerSuperIO.Modbus.Data;
using ServerSuperIO.Modbus.Common;
using ServerSuperIO.Modbus.Utility;
using System.IO;

namespace ServerSuperIO.Modbus.Message
{
	internal class ReadHoldingInputRegistersResponse : AbstractModbusMessageWithData<RegisterCollection>
    {
        public ReadHoldingInputRegistersResponse()
        {
        }

        public ReadHoldingInputRegistersResponse(byte functionCode, byte slaveAddress, RegisterCollection data)
            : base(slaveAddress, functionCode)
        {
            if (data == null)
            {
                //by cs 
                //throw new ArgumentNullException(nameof(data));
                return;
            }

            ByteCount = data.ByteCount;
            Data = data;
        }

        public byte ByteCount
        {
            get { return MessageImpl.ByteCount.Value; }
            set { MessageImpl.ByteCount = value; }
        }

        public override int MinimumFrameSize
        {
            get { return 3; }
        }

        public override string ToString()
        {
             //string msg = $"Read {Data.Count} {(FunctionCode == Modbus.ReadHoldingRegisters ? "holding" : "input")} registers.";
              string msg = "Read "+Data.Count.ToString ()+" "+ (FunctionCode == Modbus.ReadHoldingRegisters ? "holding" : "input")+" registers.";
     
            return msg;
        }

        protected override void InitializeUnique(byte[] frame)
        {
            if (frame.Length < MinimumFrameSize + frame[2])
            {
                throw new FormatException("Message frame does not contain enough bytes.");
            }

            ByteCount = frame[2];
            Data = new RegisterCollection(frame.Slice(3, ByteCount).ToArray());
        }
	}
}
