using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ModelLib.Model;

namespace PlainUDPReceiver
{
    internal class UDPReceiver
    {
        public UDPReceiver()
        {

        }

        internal void Start()
        {
            UdpClient client = new UdpClient(11001); // modtager pakker på port 11001

            byte[] buffer;

            while (true)
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
                buffer = client.Receive(ref endPoint);

                Console.WriteLine($"Modtaget pakke fra IP : {endPoint.Address} og Port : {endPoint.Port}");
                string str = Encoding.UTF8.GetString(buffer);

                Console.WriteLine("Tekst modtaget = " + str);

                byte[] outbuffer = Encoding.UTF8.GetBytes(str.ToCharArray());
                client.Send(outbuffer, outbuffer.Length, endPoint);
            }
        }
    }
}