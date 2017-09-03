using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanisere vi server og starter den ved brug af vores metode
            Server server = new Server();
            server.Start();

            Console.ReadLine(); // så vi kan se skærmbilledet
        }
    }
}
