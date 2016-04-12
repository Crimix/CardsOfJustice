using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Resources;
using Client.Properties;
using System.Windows.Forms;
using System.Drawing;

namespace Client
{
    public class ClientCard : Card
    {
        static ResourceManager rm = Resources.ResourceManager;
        PictureBox p = new PictureBox();
        public ClientCard(string card) : base(card)
        {
            
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.Size = new Size(Card.Width, Card.Height);
            p.Image = (Bitmap)rm.GetObject($"{Value}_of_{Color}");
            p.Location = new Point(120, 120);
        }

        public PictureBox Pic => p;
    }
}
