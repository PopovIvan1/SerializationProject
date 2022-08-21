using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace SerializationProject
{
    public class PersonCollection
    {
        private Collection<Person> People = new Collection<Person>();
        private string jsonString = "";

        public void GenerateCollection()
        {
            for (int i = 0; i < 10000; i++)
                People.Add(new Person());
            jsonString = JsonSerializer.Serialize(People);
        }

        public void WriteCollectionToFile()
        {
            string fileName = "Persons.json";
            using (StreamWriter sw = new StreamWriter(File.Create(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + fileName)))
            {
                sw.Write(jsonString);
            }
        }

        public void ClearCollection()
        {
            People.Clear();
        }

        public void ReadCollectionFromFile()
        {
            string fileName = "Persons.json";
            using (StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + fileName))
            {
                jsonString = sr.ReadToEnd();
                People = JsonSerializer.Deserialize<Collection<Person>>(jsonString)!;
            }
        }

        public int GetPersonCount()
        {
            int personCount = People.Count;
            return personCount;
        }

        public int GetPersonsCreditCardCount()
        {
            int personsCreditCardCount = 0;
            foreach (var Human in People)
                personsCreditCardCount += Human.CreditCardNumbers.Length;

            return personsCreditCardCount;
        }

        public float GetAverageChildAge()
        {
            float averageChildAge = 0;
            int childCount = 0;

            foreach (var Human in People)
                foreach (var Child in Human.Children)
                {
                    averageChildAge += Child.Age;
                    childCount++;
                }

            averageChildAge /= childCount;
            return averageChildAge;
        }
    }
}
