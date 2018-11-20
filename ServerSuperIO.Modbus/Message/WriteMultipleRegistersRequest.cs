﻿using ServerSuperIO.Modbus.Common;
using ServerSuperIO.Modbus.Data;
using ServerSuperIO.Modbus.Message;
using System;
using System.IO;
using System.Linq;
using System.Net;

namespace ServerSuperIO.Modbus.Message
{
	internal class WriteMultipleRegistersRequest : AbstractModbusMessageWithData<RegisterCollection>
    {
        public WriteMultipleRegistersRequest()
        {
        }

        public WriteMultipleRegistersRequest(byte slaveAddress, ushort startAddress, RegisterCollection data)
            : base(slaveAddress, Modbus.WriteMultipleRegisters)
        {
            StartAddress = startAddress;
            NumberOfPoints = (ushort)data.Count;
            ByteCount = (byte)(data.Count * 2);
            Data = data;
        }

        public byte ByteCount
        {
            get { return MessageImpl.ByteCount.Value; }
            set { MessageImpl.ByteCount = value; }
        }

        public ushort NumberOfPoints
        {
            get
            {
                return MessageImpl.NumberOfPoints.Value;
            }

            set
            {
                if (value > Modbus.MaximumRegisterRequestResponseSize)
                {
                    //by cs
                    //string msg = $"Maximum amount of data {Modbus.MaximumRegisterRequestResponseSize} registers.";
                    //throw new ArgumentOutOfRangeException(nameof(NumberOfPoints), msg);
                }

                MessageImpl.NumberOfPoints = value;
            }
        }

        public ushort StartAddress
        {
            get { return MessageImpl.StartAddress.Value; }
            set { MessageImpl.StartAddress = value; }
        }

        public override int MinimumFrameSize
        {
            get { return 7; }
        }

        public override string ToString()
        {
            //string msg = $"Write {NumberOfPoints} holding registers starting at address {StartAddress}.";
                      string msg = "Write "+NumberOfPoints.ToString ()+" holding registers starting at address "+StartAddress.ToString ()+".";
  return msg;
        }

        public void ValidateResponse(IModbusMessage response)
        {
            var typedResponse = (WriteMultipleRegistersResponse)response;

            if (StartAddress != typedResponse.StartAddress)
            {
                //by cs
                //string msg = $"Unexpected start address in response. Expected {StartAddress}, received {typedResponse.StartAddress}.";
                //throw new IOException(msg);
            }

            if (NumberOfPoints != typedResponse.NumberOfPoints)
            {
                //by cs
                //string msg = $"Unexpected number of points in response. Expected {NumberOfPoints}, received {typedResponse.NumberOfPoints}.";
                //throw new IOException(msg);
            }
        }

        protected override void InitializeUnique(byte[] frame)
        {
            if (frame.Length < MinimumFrameSize + frame[6])
            {
                throw new FormatException("Message frame does not contain enough bytes.");
            }

            StartAddress = (ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(frame, 2));
            NumberOfPoints = (ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(frame, 4));
            ByteCount = frame[6];
            Data = new RegisterCollection(frame.Slice(7, ByteCount).ToArray());
        }
    }
}
