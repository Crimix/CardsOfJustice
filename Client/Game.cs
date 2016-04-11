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
            PictureBox p = new PictureBox();
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.Size = new Size(Card.Width, Card.Height);
            p.Image = (Bitmap)rm.GetObject("Ace_of_clubs");
            p.Location = new Point(120, 120);
            this.Controls.Add(p);
        }
    }
}
