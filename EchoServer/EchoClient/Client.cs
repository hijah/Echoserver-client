using System;
using System.IO;
using System.Net.Sockets;

namespace EchoClient
{
    public class Client
    {
        //laver det hele til en metode så vi kan kalde den i program klassen
        public void start()
        {
            Console.WriteLine("Skriv din besked her");
            while (true)
            {
                //standart readline så jeg har et input
                string sendstr = Console.ReadLine();
                // her bruger jeg en "localhost" for at kalde localhost og portnr er 7
                using (TcpClient client = new TcpClient("localhost", 7))
                using (NetworkStream ns = client.GetStream())
                using (StreamReader sr = new StreamReader(ns))
                using (StreamWriter sw = new StreamWriter(ns))
                {
                    sw.WriteLine(sendstr);
                    sw.Flush();

                    string incomingstr = sr.ReadLine();
                    Console.WriteLine(incomingstr);
                }
            }







        }







    }
}