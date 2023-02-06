using System.Runtime.CompilerServices;

namespace HighAndLowApp.HighAndLow
{
	public class TrumpModel
	{
        public class Trump
        {
            public TrumpMark Mark { get; set; }
            public TrumpNumber Number { get; set; }

            public string PrintMark()
            {
                switch (Mark)
                {
                    case TrumpMark.s:
                        return "♤";
                    case TrumpMark.h:
                        return "♡";
                    case TrumpMark.c:
                        return "♧";
                    case TrumpMark.d:
                        return "♤";
                    default:
                        string errorMessage = "Unexpect output string";
                        throw new MissingMemberException(errorMessage);
                }
            }

            public string PrintNumber()
            {
                switch (Number)
                {
                    case TrumpNumber.One:
                        return "A";
                    case TrumpNumber.Two:
                        return "2";
                    case TrumpNumber.Three:
                        return "3";
                    case TrumpNumber.Four:
                        return "4";
                    case TrumpNumber.Five:
                        return "5";
                    case TrumpNumber.Six:
                        return "6";
                    case TrumpNumber.Seven:
                        return "7";
                    case TrumpNumber.Eight:
                        return "8";
                    case TrumpNumber.Nine:
                        return "9";
                    case TrumpNumber.Ten:
                        return "10";
                    case TrumpNumber.Eleven:
                        return "J";
                    case TrumpNumber.Twelve:
                        return "Q";
                    case TrumpNumber.Thirteen:
                        return "K";
                    default:
                        string errorMessage = "Unexpect output string";
                        throw new MissingMemberException(errorMessage);
                }
            }
            public string PrintNumberSpecial()
            {
                switch (Number)
                {
                    case TrumpNumber.Eleven:
                        return "JACK";
                    case TrumpNumber.Twelve:
                        return "QUEEN";
                    case TrumpNumber.Thirteen:
                        return "KING";
                    default:
                        return PrintNumber();
                }
            }
        }

        public enum TrumpMark
        {
            s = 0,
            h = 1,
            c = 2,
            d = 3
        };

        public enum TrumpNumber
        {
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Eleven = 11,
            Twelve = 12,
            Thirteen = 13
        };
	}
}
