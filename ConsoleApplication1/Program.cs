using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scan specific port
            int port = 443;
            if (TestPort(port) == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Port {0} is OPEN!<<for test", port);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Port {0} is CLOSED!", port);
            }
           
            for (int i = 1; i < 10000; i+=50) 
            {
                if (TestPort(i) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Port {0} is OPEN!", i);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Port {0} is CLOSED!", i);
                }
            }
        }

        static bool TestPort(int port)
        {
            try
            {
                TcpClient tcp = new TcpClient("127.0.0.1", port);
                if (tcp.Connected == true)
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
    }
}

