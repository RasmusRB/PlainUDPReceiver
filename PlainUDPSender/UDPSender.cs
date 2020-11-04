using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ModelLib.Model;

namespace PlainUDPSender
{
    internal class UDPSender
    {

        public UDPSender()
        {

        }

        internal void Start()
        {
            UdpClient client = new UdpClient();

            byte[] buffer;
            Car car = new Car("Tesla", "Red", "1999KA");

            // sender
            IPEndPoint modtagerEp = new IPEndPoint(IPAddress.Loopback, 11001);
            string str = car.ToString();
            byte[] outbuffer = Encoding.UTF8.GetBytes(str.ToCharArray());
            client.Send(outbuffer, outbuffer.Length, modtagerEp);

            // modtager
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref remoteEP);

            Console.WriteLine($"Modtaget pakke fra IP : {remoteEP.Address} og Port : {remoteEP.Port}");
            string incomingStr = Encoding.UTF8.GetString(buffer);

            Console.WriteLine("tekst modtaget = " + incomingStr);
        }
    }
}