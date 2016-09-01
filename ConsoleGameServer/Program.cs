using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Text;

namespace ConsoleGameServer
{
    class Program
    {
        const int ServerPortNumber = 23579;

        static void Main(string[] args)
        {
            TcpServer server = new TcpServer();
            server.Start(ServerPortNumber);

            while (true)
            {

            }
        }
    }
}
