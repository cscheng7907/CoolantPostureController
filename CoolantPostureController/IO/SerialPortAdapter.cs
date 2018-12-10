namespace ModbusTcpTerminal
{
    using System;
    using System.Diagnostics;
    using System.IO.Ports;

    //using TestModbus.IO;

    /// <summary>
    ///     Concrete Implementor - http://en.wikipedia.org/wiki/Bridge_Pattern
    /// </summary>
    public class SerialPortAdapter : IStreamResource
    {
        private const string NewLine = "\r\n";
        private SerialPort _serialPort;

        public SerialPortAdapter(SerialPort serialPort)
        {
            Debug.Assert(serialPort != null, "Argument serialPort cannot be null.");

            _serialPort = serialPort;
            _serialPort.NewLine = NewLine;
        }

        public int InfiniteTimeout
        {
            get { return SerialPort.InfiniteTimeout; }
        }

        public int ReadTimeout
        {
            get { return _serialPort.ReadTimeout; }
            set { _serialPort.ReadTimeout = value; }
        }

        public int WriteTimeout
        {
            get { return _serialPort.WriteTimeout; }
            set { _serialPort.WriteTimeout = value; }
        }

        public void DiscardInBuffer()
        {
            _serialPort.DiscardInBuffer();
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            int rt = 0;
            try
            {
                rt = _serialPort.Read(buffer, offset, count);
                _isconnected = true;
                return rt;
            }
            catch (Exception)
            {
                _isconnected = false;
                return 0;
                // throw;
            }
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            try
            {
                _serialPort.Write(buffer, offset, count);
                _isconnected = true;
            }
            catch (Exception)
            {
                _isconnected = false;
                //throw;
            }
        }


        private bool _isconnected = false;
        public bool IsConnected()
        {
            return _isconnected;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _serialPort.Dispose();
                _serialPort = null;
            }
        }
    }
}
