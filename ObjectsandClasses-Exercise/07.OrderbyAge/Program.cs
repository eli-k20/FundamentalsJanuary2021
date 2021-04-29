using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderbyAge
{
    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();

                Person person = new Person()
                {
                    Name = parts[0],
                    Id = int.Parse(parts[1]),
                    Age = int.Parse(parts[2])
                };

                people.Add(person);
            }

            List<Person> orderedList = people.OrderBy(p => p.Age).ToList();

            foreach (var person in orderedList)
            {
                Console.WriteLine(person);
            }

        }
    }
}
