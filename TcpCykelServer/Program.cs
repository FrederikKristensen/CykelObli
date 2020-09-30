using System;

namespace TcpCykelServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerWorker worker = new ServerWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
