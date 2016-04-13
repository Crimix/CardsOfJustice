﻿using Common;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ConsoleHandler.HideConsole();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsoleHandler.ShowConsole();
            Thread thread = new Thread(ServerListener.startListener);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ConsoleHandler.ShowConsole();
            //// Data buffer for incoming data.
            //byte[] bytes = new byte[1024];

            //// Connect to a remote device.
            //try
            //{
            //    // Establish the remote endpoint for the socket.
            //    // This example uses port 11000 on the local computer.
            //    IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            //    foreach (var item in ipHostInfo.AddressList)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    IPAddress ipAddress = ipHostInfo.AddressList[0];
            //    IPAddress ip;
            //    if (!IPAddress.TryParse(textBox1.Text, out ip))
            //    {
            //        return;
            //    }
            //    IPEndPoint remoteEP = new IPEndPoint(ip, 11000);

            //    // Create a TCP/IP  socket.
            //    Socket senderIP = new Socket(AddressFamily.InterNetwork,
            //        SocketType.Stream, ProtocolType.Tcp);

            //    // Connect the socket to the remote endpoint. Catch any errors.
            //    try
            //    {
            //        senderIP.Connect(remoteEP);

            //        Console.WriteLine("Socket connected to {0}",
            //            senderIP.RemoteEndPoint.ToString());

            //        // Encode the data string into a byte array.
            //        byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

            //        // Send the data through the socket.
            //        int bytesSent = senderIP.Send(msg);

            //        // Receive the response from the remote device.
            //        int bytesRec = senderIP.Receive(bytes);
            //        Console.WriteLine("Echoed test = {0}",
            //            Encoding.ASCII.GetString(bytes, 0, bytesRec));

            //        // Release the socket.
            //        senderIP.Shutdown(SocketShutdown.Both);
            //        senderIP.Close();

            //    }
            //    catch (ArgumentNullException ane)
            //    {
            //        ConsoleHandler.ShowConsole();
            //        Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            //    }
            //    catch (SocketException se)
            //    {
            //        ConsoleHandler.ShowConsole();
            //        Console.WriteLine("SocketException : {0}", se.ToString());
            //    }
            //    catch (Exception ea)
            //    {
            //        ConsoleHandler.ShowConsole();
            //        Console.WriteLine("Unexpected exception : {0}", ea.ToString());
            //    }

            //}
            //catch (Exception es)
            //{
            //    Console.WriteLine(es.ToString());
            //}
            ConsoleHandler.ShowConsole();
            this.Hide();
            Game game = new Game();
            game.FormClosed += (s, args) => Close();
            game.Show();
        }

        public string GetPublicIP()
        {
            String direction = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                direction = stream.ReadToEnd();
            }

            //Search for the ip in the html
            int first = direction.IndexOf("Address: ") + 9;
            int last = direction.LastIndexOf("</body>");
            direction = direction.Substring(first, last - first);

            return direction;
        }
    }
}
