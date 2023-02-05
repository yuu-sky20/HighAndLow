using static HighAndLowApp.HighAndLow.TrumpModel;

namespace HighAndLowApp.HighAndLow
{
	public class GameController
	{
		private Trump enemyCard = new Trump();
		private Trump myCard = new Trump();


		public (Trump enemyCard, Trump myCard) GenerateCards()
		{
			Random r = new Random();
			int enemyMark = r.Next(0, 4);
			int enemyNumber = r.Next(1, 13);
			int myMark = r.Next(0, 4);
			int myNumber = r.Next(1, 13);
			while ((enemyMark == myMark) && (enemyNumber == myNumber))
			{
                myMark = r.Next(0, 4);
                myNumber = r.Next(1, 13);
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

			return (enemyCard, myCard);
		}

		public int JudgeCards()
		{
			if (enemyCard.Number < myCard.Number)
			{
				return 1;
			} else if (enemyCard.Number > myCard.Number)
			{
				return -1;
			} else if (enemyCard == myCard)
			{
				return 0;
			} else
			{
				return 2;
			}
		}
	}
}
