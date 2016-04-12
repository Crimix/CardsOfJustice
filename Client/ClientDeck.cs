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
                flp.Controls.Add(item.Pic);
            }
            
        }
    }
}
