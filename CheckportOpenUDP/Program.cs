using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CheckportOpenUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipSever = new IPEndPoint(IPAddress.Parse("125.253.118.38"), 8830);
            Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            c.SendTimeout = 1000;
            c.ReceiveTimeout = 1000;
            //UdpClient c = new UdpClient();
         
            try
            {
                c.Connect(ipSever);
                Console.WriteLine(ipSever.ToString() + "is opened");
                c.Close();

            }
            catch
            {
                Console.WriteLine(ipSever.ToString() + "is closed");
            }
        }
    }
}
