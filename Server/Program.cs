using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Server
{
    class Program
    {
        const int portNo = 1000;
        // port number
        static void Main(string[] args)
        {
            Application.Run(new Form1());
            // define local address to listen
            System.Net.IPAddress localAdd = System.Net.IPAddress.Parse("127.0.0.1");

            //instance class to listen for tcp connections 
            TcpListener listener = new TcpListener(localAdd, portNo);

            // start listening for requests
            listener.Start();
            while (true) 
            {
                ChatClient user = new ChatClient(listener.AcceptTcpClient()); 
            }
            //Application.Run(new Form1());

        }
    }
}
