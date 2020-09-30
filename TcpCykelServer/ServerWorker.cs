using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using CykelObli;

namespace TcpCykelServer
{
    class ServerWorker
    {
        public void Start()
        {
            // creating server, with port 4646
            TcpListener server = new TcpListener(IPAddress.Loopback, 4646);
            
            // starting server
            server.Start();


            // waiting on client to make a connection
            TcpClient socket = server.AcceptTcpClient();

            StreamReader sr = new StreamReader(socket.GetStream());
            StreamWriter sw = new StreamWriter(socket.GetStream());

            // read text from client
            string str = sr.ReadLine();
            
            // server writing back
            Console.WriteLine($"This is the server input: {str}");

            //flushing the buffer
            sw.Flush();

            socket.Close();
        }
    }
}
