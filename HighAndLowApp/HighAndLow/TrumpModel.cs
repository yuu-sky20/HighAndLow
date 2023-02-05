namespace HighAndLowApp.HighAndLow
{
	public class TrumpModel
	{
        public class Trump : IComparer<Trump>
        {
            public TrumpMark Mark { get; set; }
            public TrumpNumber Number { get; set; }

            public int Compare(Trump? a, Trump? b)
            {
                if (a == null || b == null)
                {
                    return 2;
                }
                if (a.Number > b.Number)
                {
                    return 1;
                } else if (a.Number < b.Number)
                {
                    return -1;
                } else
                {
                    return 0;
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
            A = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            J = 10,
            Q = 11,
            K = 12
        };
	}
}
