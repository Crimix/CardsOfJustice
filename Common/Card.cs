
using System;

namespace Common
{
    public class Card : IComparable
    {

        public enum value
        {
            Three = 3,
            Four = 4,
            Six = 5,
            Seven = 6,
            Eight = 7,
            Nine = 8,
            Ten = 9,
            Jack = 10,
            Queen = 11,
            King = 12,
            Ace = 13,
            Two = 14,
            Five = 15,
            Joker = 16,
            Multi = 17
        }

        public enum color
        {
            hearts = 1,
            spades = 2,
            diamonds = 3,
            clubs = 4,
        }

        private value v;
        private color c;

        public Card(string card)
        {
            string[] var = card.Split(':');
            v = (value)int.Parse(var[0]);
            if (!var[1].Equals(""))
            {
                c = (color)int.Parse(var[1]);
            }
        }

        public value Value => v;
        public color Color => c;
        public string ValueString => v.ToString();
        public string ColorString => c.ToString();
        public static int Height => 112;
        public static int Width => 78;

        public static int GetSortNumber(Card card)
        {
            if (card.Value == value.Multi)
            {
                return 180;
            }
            else if (card.Value == value.Five && card.Color == color.clubs)
            {
                return 179;
            }
            else
            {
                return (((int)card.Value) * 10) + ((int)card.Color);

            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Card otherCard = obj as Card;
            if (otherCard != null)
                return GetSortNumber(this).CompareTo(GetSortNumber(otherCard));
            else
                throw new ArgumentException("Object is not a Card");
        }
    }
}
