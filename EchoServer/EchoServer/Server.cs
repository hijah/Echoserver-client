using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace EchoServer
{
    public class Server
    {

        public Server()
        {

        }
        //laver det hele til en metode så vi kan kalde den i program klassen
        public void Start()
        {
            //IPAddress er loopback pga. den skal være til localhost, 7 er portnr.
            TcpListener server = new TcpListener(IPAddress.Loopback, 7);
            server.Start();
            //server er startet

            //Loop for at kunne sende mere end en besked
            while (true)
            {
                //server acceptere client
                using (TcpClient client = server.AcceptTcpClient())
                //her siger vi at networkstream skal tage den info vi modtager fra clienten
                using (NetworkStream ns = client.GetStream())
                // vi instanisere Streamreader og writer så vi kan bruge dem. Streamreader virker lidt som readline dvs. streamwriter virker som en slags writeline
                using (StreamReader sr = new StreamReader(ns))
                using (StreamWriter sw = new StreamWriter(ns))
                {
                    //læser hvad sr modtager
                    string inlinje = sr.ReadLine();
                    //denne metode bruger jeg så jeg kan se hvor mange ord som er skrevet. (var i opgaven)
                    int inlinjeCount = inlinje.Split().Length;
                    
                    Console.WriteLine(inlinje + "\n" + "antal ord: " + inlinjeCount);
                    //her skriver vi til clienten at beskeden er modtaget. Laver et echo tilbage
                    sw.WriteLine("beskeden er modtaget");
                    //sw.WriteLine(inlinje);
                    //sender dataen afsted (virker som et toilet, så hvis du ikke flusher kommer det ikke videre)
                    sw.Flush();
                    
                }
            }



        }


    }
}