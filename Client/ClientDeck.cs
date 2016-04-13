using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Windows.Forms;

namespace Client
{
    public class ClientDeck : Deck
    {
        public ClientDeck() : base()
        {

        }

        public void DisplayDeck(FlowLayoutPanel flp)
        {
            foreach (ClientCard item in GetDeck)
            {
                PictureBox pic = item.Pic;
                pic.MouseClick += Pic_MouseClick;
                flp.Controls.Add(pic);
            }
            
        }

        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
            ConsoleHandler.ShowConsole();
            if (sender is PictureBox)
            {
                Console.WriteLine(((PictureBox)sender).Name);
            }
        }
    }
}
