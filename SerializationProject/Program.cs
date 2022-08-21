using System;

namespace SerializationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonCollection pc = new PersonCollection();

            pc.GenerateCollection();
            pc.WriteCollectionToFile();
            pc.ClearCollection();
            pc.ReadCollectionFromFile();

            Console.WriteLine($"Person count: {pc.GetPersonCount()}");
            Console.WriteLine($"Persons credit card count: {pc.GetPersonsCreditCardCount()}");
            Console.WriteLine($"Average child age: {pc.GetAverageChildAge()}");
        }
    }
}
