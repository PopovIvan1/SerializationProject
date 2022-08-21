using System;

namespace SerializationProject
{
    public class Names
    {
        private string[] names;
        private string[] lastNames;

        public string GetName()
        {
            return names[new Random().Next() % names.Length];
        }

        public string GetLastName()
        {
            return lastNames[new Random().Next() % lastNames.Length];
        }

        public Names(Gender gender)
        {
            if (gender == Gender.Male)
                names = new string[10] { "Noah", "Liam", "Mason", "Jacob", "William", "Ethan", "Michael", "Alexander", "Alfred", "Brian" };
            else
                names = new string[10] { "Olivia", "Agata", "Agnes", "Ida", "Emma", "Amelia", "Sophia", "Isabella", "Mia", "Ava" };

            lastNames = new string[10] { "Smith", "Johnson", "Brown", "Jones", "Miller", "Davis", "Wilson", "Anderson", "Thomas", "Thompson" };
        }
    }
}
