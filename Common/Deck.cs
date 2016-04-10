using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    public class Deck
    {
        private List<Card> deck = new List<Card>();
        public Deck()
        {

        }

        public void AddCard(Card card)
        {
            deck.Add(card);
        }

        public void RemoveCard(Card card)
        {
            deck.Remove(card);
        }

    }
}
