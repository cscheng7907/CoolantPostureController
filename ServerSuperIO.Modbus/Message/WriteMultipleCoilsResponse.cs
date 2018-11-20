using System;
using System.Net;
namespace ServerSuperIO.Modbus.Message
{
	internal class WriteMultipleCoilsResponse : AbstractModbusMessage
    {
        public WriteMultipleCoilsResponse()
        {
			
        }

        public WriteMultipleCoilsResponse(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
            : base(slaveAddress, Modbus.WriteMultipleCoils)
        {
            StartAddress = startAddress;
            NumberOfPoints = numberOfPoints;
        }

        public ushort NumberOfPoints
        {
            get
            {
                return MessageImpl.NumberOfPoints.Value;
            }

            set
            {
                if (value > Modbus.MaximumDiscreteRequestResponseSize)
                {
                    //by cs
                    //string msg = $"Maximum amount of data {Modbus.MaximumDiscreteRequestResponseSize} coils.";
                    //throw new ArgumentOutOfRangeException("NumberOfPoints", msg);
                }
                else
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
            get { return 6; }
        }

        public override string ToString()
        {
            //string msg = $"Wrote {NumberOfPoints} coils starting at address {StartAddress}.";
                     string msg = "Wrote "+NumberOfPoints.ToString ()+" coils starting at address "+StartAddress.ToString ()+".";
 
            return msg;
        }

        protected override void InitializeUnique(byte[] frame)
        {
            StartAddress = (ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(frame, 2));
            NumberOfPoints = (ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(frame, 4));
        }
    }
}
