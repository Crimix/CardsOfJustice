using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ConnectionHandler
    {
        public ConnectionHandler()
        {

        }

        public void connect(string ipString)
        {
            ConsoleHandler.ShowConsole();
            // Data buffer for incoming data.
            byte[] bytes = new byte[1024];

            // Connect to a remote device.
            try
            {
                IPAddress ip;
                if (!IPAddress.TryParse(ipString, out ip))
                {
                    return;
                }
                IPEndPoint remoteEP = new IPEndPoint(ip, 11000);

                // Create a TCP/IP  socket.
                Socket senderIP = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    senderIP.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        senderIP.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.
                    byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

                    // Send the data through the socket.
                    int bytesSent = senderIP.Send(msg);

                    // Receive the response from the remote device.
                    int bytesRec = senderIP.Receive(bytes);
                    Console.WriteLine("Echoed test = {0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    // Release the socket.
                    senderIP.Shutdown(SocketShutdown.Both);
                    senderIP.Close();

                }
                catch (ArgumentNullException ane)
                {
                    ConsoleHandler.ShowConsole();
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    ConsoleHandler.ShowConsole();
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception ea)
                {
                    ConsoleHandler.ShowConsole();
                    Console.WriteLine("Unexpected exception : {0}", ea.ToString());
                }

            }
            catch (Exception es)
            {
                Console.WriteLine(es.ToString());
            }
        }


    }
}
