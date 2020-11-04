using System;

namespace PlainUDPReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPReceiver worker = new UDPReceiver();
            worker.Start();

            Console.ReadLine();
        }
    }
}
