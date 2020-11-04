using System;

namespace JsonUDPReceiver
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
