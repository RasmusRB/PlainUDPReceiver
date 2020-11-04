using System;

namespace JsonUDPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSender worker = new UDPSender();
            worker.Start();

            Console.ReadLine();
        }
    }
}
