using System;

namespace SerializationProject
{
    public class RandomGenerator
    {
		public Int64 generateBirthDate(int Age)
		{
			Random rnd = new Random();
			int year = DateTime.Now.Year - Age;
			int month = rnd.Next() % 12 + 1;
			int day = rnd.Next() % 28 + 1;
			DateTimeOffset dto = new DateTimeOffset(year, month, day, 0, 0, 0, TimeSpan.Zero);
			return dto.ToUnixTimeSeconds();
		}

		public string[] generatePhones()
		{
			Random rnd = new Random();
			return numberGenerator(rnd.Next() % 3 + 1, 10);
		}

		public string[] generateCreditCards()
		{
			Random rnd = new Random();
			return numberGenerator(rnd.Next() % 4 + 1, 13);
		}

		private string[] numberGenerator(int count, int length)
		{
			Random rnd = new Random();
			string[] numbers = new string[rnd.Next() % count + 1];
			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = (rnd.Next() % 9 + 1).ToString();
				for (int j = 0; j < length - 1; j++) numbers[i] += (rnd.Next() % 10).ToString();
			}
			return numbers;
		}
	}
}
