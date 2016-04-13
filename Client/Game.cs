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
            p.ReciveCard("4:2");
            p.ReciveCard("4:2");
            p.ReciveCard("15:2");
            p.ReciveCard("7:2");
            p.ReciveCard("4:2");
            p.ReciveCard("4:2");
            p.ReciveCard("4:2");
            p.ReciveCard("8:2");
            p.ReciveCard("4:2");
            p.ReciveCard("14:2");
            p.ReciveCard("13:2");
            p.ReciveCard("4:2");
            p.ReciveCard("4:2");
            p.ReciveCard("4:2");
            p.ReciveCard("12:2");
            p.ReciveCard("4:4");
            p.ReciveCard("4:3");
            p.ReciveCard("4:1");
            p.ReciveCard("15:4");
            p.ReciveCard("16:");
            p.Deck.sort();
            p.Deck.DisplayDeck(flowLayoutPanel1);
        }
    }
}
