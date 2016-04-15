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
            p.Name = $"{Value}_of_{Color}";
            //p.Location = new Point(120, 120);
        }

        private void ChangeImage()
        {
            using (Graphics grfx = Graphics.FromImage(p.Image))
            {
                grfx.DrawImage(Resources.gray, 0, 0);
            }

        }
        public void IsMulti()
        {
            using (Graphics grfx = Graphics.FromImage(p.Image))
            {
                grfx.DrawImage(Resources.Multi_overlay, 0, 0);
            }
        }

        public bool Enabled {
            get{
                return p.Enabled;
            }
            set{
                p.Enabled = value;
                ChangeImage();
            }
        }


        public PictureBox Pic => p;
    }
}
