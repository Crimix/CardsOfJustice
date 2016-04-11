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

        public void MakeServerDeck()
        {
            for (int i = 3; i < 16; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    AddCard(new Card($"{i}:{j}"));
                }
            }
            AddCard(new Card("16:"));
            AddCard(new Card("16:"));
            AddCard(new Card("16:"));
            AddCard(new Card("16:"));
            AddCard(new Card("17:"));
            Shuffle();
            foreach (Card item in deck)
            {
                Console.WriteLine($"{item.ValueString} of {item.ColorString}");
            }
            
        }

    }
}
