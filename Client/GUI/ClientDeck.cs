using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Windows.Forms;
using Client.Properties;

namespace Client
{
    public class ClientDeck : Deck
    {
        private List<Card> cardsToPlay = new List<Card>();
        public ClientDeck() : base()
        {

        }

        public void DisplayDeck(FlowLayoutPanel flp)
        {
            foreach (ClientCard item in GetDeck)
            {
                item.Enabled = false;
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
                Card c = GetDeck.Find(x => x.Name.Equals(((PictureBox)sender).Name));
                Console.WriteLine(c.Name);
            }
        }
    }
}
