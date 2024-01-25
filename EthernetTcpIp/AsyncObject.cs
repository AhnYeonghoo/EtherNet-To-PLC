using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.IO;
using System.Text;




namespace rev
{
    // 비동기 작업에서 사용하는 소켓과 해당 작업에 대한
    // 데이터 버퍼를 저장하는 클래스

    public class AsyncObject
    {
        Socket mainSock;
        System.Net.IPAddress thisAddress;
        List<Socket> connectedClients = new List<Socket>();
        int port = 9009;
        public byte[] buffer;
        public Socket workingSocket;
        public readonly int bufferSize;

        public AsyncObject(int bufferSize)
        {
            this.bufferSize = bufferSize;
            buffer = new byte[bufferSize];
        }

        public void ClearBuffer()
        {
            Array.Clear(buffer, 0, bufferSize);
        }
        

        private void Server()
        {
            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            System.Net.IPEndPoint serverEP = new System.Net.IPEndPoint(System.Net.IPAddress.Any, port);
            mainSock.Bind(serverEP);
            mainSock.Listen(10);
            mainSock.BeginAccept(AcceptCallback, null);
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            Socket client = mainSock.EndAccept(ar);
            mainSock.BeginAccept(AcceptCallback, null);
            AsyncObject obj = new AsyncObject(8);
            obj.workingSocket = client;
            connectedClients.Add(client);
            client.BeginReceive(obj.buffer, 0, 8, 0, DataReceived, obj);

        }
        private void DataReceived(IAsyncResult ar)
        {
            AsyncObject obj = (AsyncObject)ar.AsyncState;
            try
            {
                int received = obj.workingSocket.EndReceive(ar);
                if (received <= 0)
                {
                    obj.workingSocket.Close();
                    return;
                }
            }
            catch
            {
                return;
            }

            try
            {
                string text = Encoding.ASCII.GetString(obj.buffer);
                obj.ClearBuffer();
                obj.workingSocket.BeginReceive(obj.buffer, 0, 8, 0, DataReceived, obj);
            }
            catch (Exception ex)
            {

            }
        }
        private void sendingMES(string tts)
        {
            byte[] bDts = Encoding.ASCII.GetBytes(tts);
            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                try
                {
                    socket.Send(bDts);
                }
                catch
                {
                    connectedClients.RemoveAt(i);
                }
            }


        }
    }
}