using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    public class Deck
    {
        private static Random rng = new Random();
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

        public void Shuffle()
        {
            for (int n = deck.Count - 1; n > 0; --n)
            {
                int k = rng.Next(n + 1);
                Card temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }
        }

    }
}
