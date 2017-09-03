using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanisere vi clienten og starter den ved brug af vores metode
            Client client = new Client();
            client.start();


            Console.ReadLine(); // så vi kan se skærmbilledet


        }
    }
}
