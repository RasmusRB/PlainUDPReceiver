using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ModelLib.Model;
using Newtonsoft.Json;

namespace JsonUDPReceiver
{
    internal class UDPReceiver
    {

        public UDPReceiver()
        {

        }

        internal void Start()
        {
            UdpClient client = new UdpClient(11002); // modtager pakker på port 11002

            byte[] buffer;

            while (true)
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
                buffer = client.Receive(ref endPoint);

                Console.WriteLine($"Modtaget pakke fra IP : {endPoint.Address} og Port : {endPoint.Port}");
                string json = Encoding.UTF8.GetString(buffer);

                Car car = JsonConvert.DeserializeObject<Car>(json);

                Console.WriteLine("Tekst modtaget = " + car);

                byte[] outbuffer = Encoding.UTF8.GetBytes(json.ToCharArray());
                client.Send(outbuffer, outbuffer.Length, endPoint);
            }
        }
    }
}