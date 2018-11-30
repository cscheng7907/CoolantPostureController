using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ModbusTcpTerminal;
using ServerSuperIO.Modbus.Device;
using ServerSuperIO.Modbus.Message;
using System.Threading;

namespace CoolantPostureController.DataPoll
{
    public class IODeviceDataPoll : DeviceDataPollbase
    {
        private const byte slaveId = 1;
        //private ushort startAddress = 0;
        private const ushort numRegisters = 1;

        private IStreamResource _streamRes = null;
        public IStreamResource StreamRes
        {
            set
            {
                if (_streamRes != value)
                    _streamRes = value;
            }
        }

        private IModbusMaster _modbusmaster = null;
        public IModbusMaster ModbusMaster
        { set { if (_modbusmaster != value) _modbusmaster = value; } }


        public override  ushort ReadSingleHoldingRegisters(ushort startAddress)
        {
            //return 0;

            ushort res = 0;

            if (_modbusmaster != null && _streamRes != null)
            {
                try
                {
                    IModbusMessage request;
                    byte[] sendBytes = _modbusmaster.BuildReadHoldingRegistersCommand(slaveId, startAddress, numRegisters, out request);
                    _streamRes.Write(sendBytes, 0, sendBytes.Length);

                    byte[] readBuffer = new byte[1024];

                    Thread.Sleep(50);
                    int num = _streamRes.Read(readBuffer, 0, readBuffer.Length);

                    if (num > 3)
                    {
                        byte[] readBytes = new byte[num];
                        Buffer.BlockCopy(readBuffer, 0, readBytes, 0, num);

                        ushort[] response = _modbusmaster.GetReadHoldingRegistersResponse(readBytes, request);

                        if (response.Length > 0)
                        {
                            //SetRightAns(true);
                            res = response[0];
                            //return response[0];
                        }
                        else
                        {
                            //SetRightAns(false);
                            //return 0;
                        }
                    }
                    else
                    {
                        //SetRightAns(false);
                        //return 0;
                    }
                }
                finally
                {
                    //return 0;
                }
            }

            return res;

        }

        public override void WriteSingleRegister(ushort startAddress, ushort value)
        {
            if (_modbusmaster != null && _streamRes != null)
            {
                try
                {
                    try
                    {
                        IModbusMessage request;
                        byte[] sendBytes = _modbusmaster.BuildWriteSingleRegisterCommand(slaveId, startAddress, value, out request);
                        _streamRes.Write(sendBytes, 0, sendBytes.Length);

                        Thread.Sleep(50);

                        byte[] readBuffer = new byte[1024];
                        int num = _streamRes.Read(readBuffer, 0, readBuffer.Length);
                        if (num > 3)
                        {

                            byte[] readBytes = new byte[num];
                            Buffer.BlockCopy(readBuffer, 0, readBytes, 0, num);

                            _modbusmaster.ValidateWriteSingleRegisterResponse(readBytes, request);
                            //SetRightAns(true);

                        }
                        else
                        {
                            //SetRightAns(false);
                        }

                    }
                    catch (Exception ex)
                    {
                        //SetRightAns(false);
                        //Console.WriteLine(ex.Message);
                    }
                }
                finally
                {

                }
            }
        }

        public override bool[] ReadCoils(ushort startAddress, ushort length)
        {
            if (_modbusmaster != null && _streamRes != null)
            {
                try
                {
                    IModbusMessage request;
                    byte[] sendBytes = _modbusmaster.BuildReadCoilsCommand(slaveId, startAddress, length, out request);
                    _streamRes.Write(sendBytes, 0, sendBytes.Length);

                    byte[] readBuffer = new byte[1024];

                    Thread.Sleep(50);
                    int num = _streamRes.Read(readBuffer, 0, readBuffer.Length);

                    if (num > 3)
                    {
                        byte[] readBytes = new byte[num];
                        Buffer.BlockCopy(readBuffer, 0, readBytes, 0, num);

                        bool[] response = _modbusmaster.GetReadCoilsResponse(readBytes, length, request);

                        if (response.Length > 0)
                        {
                            return response;
                        }
                        else
                        {
                            ;
                        }
                    }
                    else
                    {

                    }
                }
                finally
                {

                }
            }

            return null;
        }


        public override bool[] ReadInputs(ushort startAddress, ushort length)
        {
            if (_modbusmaster != null && _streamRes != null)
            {
                try
                {
                    IModbusMessage request;
                    byte[] sendBytes = _modbusmaster.BuildReadInputsCommand (slaveId, startAddress, length, out request);
                    _streamRes.Write(sendBytes, 0, sendBytes.Length);

                    byte[] readBuffer = new byte[1024];

                    Thread.Sleep(50);
                    int num = _streamRes.Read(readBuffer, 0, readBuffer.Length);

                    if (num > 3)
                    {
                        byte[] readBytes = new byte[num];
                        Buffer.BlockCopy(readBuffer, 0, readBytes, 0, num);

                        bool[] response = _modbusmaster.GetReadInputsResponse(readBytes, length, request);

                        if (response.Length > 0)
                        {
                            return response;
                        }
                        else
                        {
                            ;
                        }
                    }
                    else
                    {

                    }
                }
                finally
                {

                }
            }

            return null;
        }

        public override void WriteSingleCoil(ushort startAddress, bool value)
        {
            if (_modbusmaster != null && _streamRes != null)
            {
                try
                {
                    IModbusMessage request;
                    byte[] sendBytes = _modbusmaster.BuildWriteSingleCoilCommand(slaveId, startAddress, value, out request);
                    _streamRes.Write(sendBytes, 0, sendBytes.Length);

                    byte[] readBuffer = new byte[1024];

                    Thread.Sleep(50);
                    int num = _streamRes.Read(readBuffer, 0, readBuffer.Length);

                    if (num > 3)
                    {
                        //byte[] readBytes = new byte[num];
                        //Buffer.BlockCopy(readBuffer, 0, readBytes, 0, num);

                        //bool[] response = _modbusmaster.GetReadCoilsResponse(readBytes, length, request);

                        //if (response.Length > 0)
                        //{
                        //    return response;
                        //}
                        //else
                        //{
                        //    ;
                        //}
                    }
                    else
                    {

                    }
                }
                finally
                {

                }
            }

        
        
        }

    }
}
