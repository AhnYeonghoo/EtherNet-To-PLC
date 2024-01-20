using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class ClientProgram
    {
        public static void Client()
        {
            Console.WriteLine("클라이언트 콘솔창 \n\n\n");
            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 9998);
            byte[] buffer = Encoding.Default.GetBytes("클라이언트 : 접속합니다.");
            client.GetStream().Write(buffer, 0, buffer.Length);
            client.Close();
        }
    }
}
