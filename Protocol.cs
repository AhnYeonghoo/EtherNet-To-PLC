using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Protocol
    {
        private void CheckAsciiFrame(string strFrame)
        {
            string s = strFrame.Substring(18, 4);
            if (strFrame[0] != 'D' || strFrame[1] != '0' || strFrame[2] != '0' || strFrame[3] != '0')
                throw new Exception("Invalid SubHeader!", new object[0]);
            if (strFrame[4] != '0' || strFrame[5] != '0' || strFrame[6] != 'F' || strFrame[7] != 'F')
                throw new Exception("Invalid Network or PC Number!", new object[0]);
            if (strFrame[8] != '0' || strFrame[9] != '3' || strFrame[10] != 'F' || strFrame[11] != 'F' || strFrame[12] != '0' || strFrame[13] != '0')
                throw new Exception("Invalid Specific Value!", new object[0]);
            ushort num = ushort.Parse(s, NumberStyles.HexNumber);
            if (num != (ushort)0)
                throw new Exception("Invalid Response Code! (Error={0})", new object[1]
                {
          (object) num
                });
        }

        private void CheckBinaryFrame(byte[] ucFrameBuffer, int nBufferLength)
        {
            if (ucFrameBuffer[0] != (byte)208 || ucFrameBuffer[1] != (byte)0)
                throw new TcpException("Invalid SubHeader!", new object[0]);
            if (ucFrameBuffer[2] != (byte)0 || ucFrameBuffer[3] != byte.MaxValue)
                throw new TcpException("Invalid Network or PC Number!", new object[0]);
            if (ucFrameBuffer[4] != byte.MaxValue || ucFrameBuffer[5] != (byte)3 || ucFrameBuffer[6] != (byte)0)
                throw new TcpException("Invalid Specific Value!", new object[0]);
            ushort num = (ushort)((uint)ucFrameBuffer[10] << 8 | (uint)ucFrameBuffer[9]);
            if (num > (ushort)0)
                throw new TcpException("Invalid Response Code! (Error={0})", new object[1]
                {
          (object) num
                });
        }

        private int GetAsciiByteSize(int nDeviceCode)
        {
            switch (nDeviceCode)
            {
                case 66:
                case 77:
                case 88:
                case 89:
                    return 1;
                case 68:
                case 82:
                case 87:
                    return 2;
                default:
                    throw new MelsecException("Invalid Device Name! (name={0})", new object[1]
                    {
            (object) (char) nDeviceCode
                    });
            }
        }
    }
}
