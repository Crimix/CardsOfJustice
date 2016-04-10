
namespace Common
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
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
            Joker = 14,
            Multi = 15
        }

        public enum color
        {
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
            if (var.Length == 2)
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
            int result = 0;
            if(card.Value == value.Multi)
            {
                return 57;
            }
            switch (card.Value)
            {
                case value.Joker:
                    result = 55;
                    break;
                case value.Five:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 53;
                            break;
                        case color.spades:
                            result = 54;
                            break;
                        case color.diamond:
                            result = 54;
                            break;
                        case color.clubs:
                            result = 56;
                            break;
                    }
                    break;
                case value.Two:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 49;
                            break;
                        case color.spades:
                            result = 50;
                            break;
                        case color.diamond:
                            result = 51;
                            break;
                        case color.clubs:
                            result = 52;
                            break;
                    }
                    break;
                case value.Ace:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 45;
                            break;
                        case color.spades:
                            result = 46;
                            break;
                        case color.diamond:
                            result = 47;
                            break;
                        case color.clubs:
                            result = 48;
                            break;
                    }
                    break;
                case value.King:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 41;
                            break;
                        case color.spades:
                            result = 42;
                            break;
                        case color.diamond:
                            result = 43;
                            break;
                        case color.clubs:
                            result = 44;
                            break;
                    }
                    break;
                case value.Queen:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 37;
                            break;
                        case color.spades:
                            result = 38;
                            break;
                        case color.diamond:
                            result = 39;
                            break;
                        case color.clubs:
                            result = 40;
                            break;
                    }
                    break;
                case value.Jack:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 33;
                            break;
                        case color.spades:
                            result = 34;
                            break;
                        case color.diamond:
                            result = 35;
                            break;
                        case color.clubs:
                            result = 36;
                            break;
                    }
                    break;
                case value.Ten:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 29;
                            break;
                        case color.spades:
                            result = 30;
                            break;
                        case color.diamond:
                            result = 31;
                            break;
                        case color.clubs:
                            result = 32;
                            break;
                    }
                    break;
                case value.Nine:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 25;
                            break;
                        case color.spades:
                            result = 26;
                            break;
                        case color.diamond:
                            result = 27;
                            break;
                        case color.clubs:
                            result = 28;
                            break;
                    }
                    break;
                case value.Eight:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 21;
                            break;
                        case color.spades:
                            result = 22;
                            break;
                        case color.diamond:
                            result = 23;
                            break;
                        case color.clubs:
                            result = 24;
                            break;
                    }
                    break;
                case value.Seven:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 17;
                            break;
                        case color.spades:
                            result = 18;
                            break;
                        case color.diamond:
                            result = 19;
                            break;
                        case color.clubs:
                            result = 20;
                            break;
                    }
                    break;
                case value.Six:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 13;
                            break;
                        case color.spades:
                            result = 14;
                            break;
                        case color.diamond:
                            result = 15;
                            break;
                        case color.clubs:
                            result = 16;
                            break;
                    }
                    break;
                case value.Four:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 9;
                            break;
                        case color.spades:
                            result = 10;
                            break;
                        case color.diamond:
                            result = 11;
                            break;
                        case color.clubs:
                            result = 12;
                            break;
                    }
                    break;
                case value.Three:
                    switch (card.Color)
                    {
                        case color.hearts:
                            result = 5;
                            break;
                        case color.spades:
                            result = 6;
                            break;
                        case color.diamond:
                            result = 7;
                            break;
                        case color.clubs:
                            result = 8;
                            break;
                    }
                    break;
            }
            return result;
        }

    }
}
