using Client.Properties;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Game : Form
    {
        ResourceManager rm = Resources.ResourceManager;
        public Game()
        {
            InitializeComponent();
            Player p = new Player("DonF");
            p.ReciveCard("3:2");
            p.ReciveCard("4:2");
            p.Deck.DisplayDeck(flowLayoutPanel1);
        }
    }
}
