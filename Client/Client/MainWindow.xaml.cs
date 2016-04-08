using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void host_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Join_Click(object sender, RoutedEventArgs e)
        {
            // Data buffer for incoming data.
            byte[] bytes = new byte[1024];

            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                // This example uses port 11000 on the local computer.
                IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                //IPAddress ip = IPAddress.Parse(textBox.Text);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress,11000);

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
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception ea)
                {
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
