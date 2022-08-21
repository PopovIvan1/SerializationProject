using System;


namespace SerializationProject
{
	public class Person
	{
		public Int32 Id { get; set; }
		public Guid TransportId { get; set; }
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public Int32 SequenceId { get; set; }
		public String[] CreditCardNumbers { get; set; }
		public Int32 Age { get; set; }
		public String[] Phones { get; set; }
		public Int64 BirthDate { get; set; }
		public Double Salary { get; set; }
		public Boolean IsMarred { get; set; }
		public Gender Gender { get; set; }
		public Child[] Children { get; set; }

		public Person()
		{
			Random rnd = new Random();
			Id = rnd.Next();
			TransportId = Guid.NewGuid();
			if (rnd.Next() % 2 == 0)
				Gender = Gender.Male;
			else Gender = Gender.Female;

			Names names = new Names(Gender);
			FirstName = names.GetName();
			LastName = names.GetLastName();

			SequenceId = rnd.Next();
			Salary = (rnd.Next() % 100 + 1) * 10000;
			if (rnd.Next() % 2 == 0)
				IsMarred = true;
			else IsMarred = false;
			Age = rnd.Next() % 50 + 20;

			BirthDate = new RandomGenerator().generateBirthDate(Age);
			Phones = new RandomGenerator().generatePhones();
			CreditCardNumbers = new RandomGenerator().generateCreditCards();

			Children = new Child[rnd.Next() % 3];
			for (int i = 0; i < Children.Length; i++)
				Children[i] = new Child(LastName);
		}
	}

	public class Child
	{
		public Int32 Id { get; set; }
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public Int32 Age { get; set; }
		public Int64 BirthDate { get; set; }
		public Gender Gender { get; set; }

		public Child(string lastName)
		{
			Random rnd = new Random();
			Id = rnd.Next();

			Names names = new Names(Gender);
			FirstName = names.GetName();
			LastName = lastName;

			Age = rnd.Next() % 12 + 4;
			if (rnd.Next() % 2 == 0)
				Gender = Gender.Male;
			else Gender = Gender.Female;

			BirthDate = new RandomGenerator().generateBirthDate(Age);
		}

		public Child()
		{

		}
	}

	public enum Gender
	{
		Male,
		Female
	}
}
