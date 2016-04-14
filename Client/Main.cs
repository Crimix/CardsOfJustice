using Common;
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
            this.Hide();
            Game game = new Game();
            game.FormClosed += (s, args) => Close();
            game.Show();
        }

    }
}
