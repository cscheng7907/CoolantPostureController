﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ModbusTcpTerminal;
using ServerSuperIO.Modbus.Device;
using ServerSuperIO.Modbus.Message;
using System.Threading;


namespace CoolantPostureController.DataPoll
{
    public class DriverDeviceDataPoll : DeviceDataPollbase
    {
        private const byte slaveId = 2;
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


        public override ushort ReadSingleHoldingRegisters(ushort startAddress)
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
                            _connected = true;
                            //return response[0];
                        }
                        else
                        {
                            _connected = false;
                            //SetRightAns(false);
                            //return 0;
                        }
                    }
                    else
                    {
                        _connected = false;
                        //SetRightAns(false);
                        //return 0;
                    }
                }
                finally
                {
                    //return 0;
                }
            }
            else
            {
                _connected = false;
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
                            _connected = true;
                        }
                        else
                        {
                            _connected = false;
                            //SetRightAns(false);
                        }

                    }
                    catch (Exception ex)
                    {
                        _connected = false;
                        //SetRightAns(false);
                        //Console.WriteLine(ex.Message);
                    }
                }
                finally
                {

                }
            }
            else
            {
                _connected = false;
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
                            _connected = true; 
                            return response;
                        }
                        else
                        {
                            _connected = false;
                        }
                    }
                    else
                    {
                        _connected = false;
                    }
                }
                finally
                {

                }
            }
            else
                _connected = false;

            return null;
        }
        //public override bool[] ReadInputs(ushort startAddress, ushort length)
        //{ return null; }

    }
}
