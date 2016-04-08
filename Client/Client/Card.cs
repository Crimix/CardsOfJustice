
namespace Client
{
    public class Card
    {
        public enum value
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
            Joker = 14,
            Multi = 15
        }

        public enum color
        {
            r = -1,
            b = 0,
            hearts = 1,
            spades = 2,
            diamond = 3,
            clubs = 4,
        }

        private value v;
        private color c;

        public Card(string card)
        {
            string[] var = card.Split(':');
            v = (value)int.Parse(var[0]);
            c = (color)int.Parse(var[1]);
        }

        public value Value() => v;
        public color Color() => c;
        public string ValueString() => v.ToString();
        public string ColorString() => c.ToString();


    }
}
