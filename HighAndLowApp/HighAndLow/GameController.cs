using static HighAndLowApp.HighAndLow.TrumpModel;

namespace HighAndLowApp.HighAndLow
{
	public class GameController
	{
		private Trump enemyCard = new Trump();
		private Trump myCard = new Trump();
		private int winningCount = 0;

		public (Trump? enemyCard, Trump? myCard) GenerateCards()
		{
			Random r = new Random();
			int enemyMark = r.Next(0, 4);
			int enemyNumber = r.Next(1, 13);
			int myMark = r.Next(0, 4);
			int myNumber = r.Next(1, 13);
			while ((enemyNumber == myNumber))
			{
                myMark = r.Next(0, 4);
                myNumber = r.Next(1, 13);
				if (enemyMark != myMark && enemyNumber == myNumber) break;
			}

			enemyCard = new Trump()
			{
				Mark = (TrumpMark)enemyMark,
				Number = (TrumpNumber)enemyNumber
			};
			myCard = new Trump()
			{
				Mark = (TrumpMark)myMark,
				Number = (TrumpNumber)myNumber
			};

			return (enemyCard, null);
		}

		public (Trump enemyCard, Trump? myCard) GenerateCards(int i, int j)
		{
			enemyCard = new Trump()
			{
				Mark = (TrumpMark)i,
				Number = (TrumpNumber)j
			};
			return (enemyCard, null);
		}

		public (Trump enemyCard, Trump myCard) OpenCards()
		{
			return (enemyCard, myCard);
		}

		public (bool isWin, int winningCount) JudgeCards(HighAndLow highAndLow)
		{
			bool f = true;
			if (highAndLow == HighAndLow.LOW)
			{
				if (enemyCard.Number < myCard.Number)
				{
					f = false;
				}
			} else
			{
				if (enemyCard.Number > myCard.Number)
				{
					f = false;
				}
			}

			if (f)
			{
				winningCount++;
			} else
			{
				winningCount = 0;
			}

			return (f, winningCount);
		}

		public enum HighAndLow
		{
			LOW,
			HIGH
		}
	}
}
