using System;
using System.Linq;
using System.Collections.Generic;

namespace mars13_linq
{
    class Program
    {
        static bool Compare (Person p)
        {
            return p.Age < 50;
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
            new Person { Name = "Håkan", Age = 56 },
            new Person { Name = "Pontus", Age = 40 },
            new Person { Name = "Gabriella", Age = 30 }
            };

            var q = people.FirstOrDefault(Compare);
            Console.WriteLine(q);
            Console.WriteLine();
            var sameAsAbove = people.FirstOrDefault(p => p.Age < 50);

            var peopleList = people.OrderBy(p => p.Name);
            //exakt samma kodrad som ovan fast skrivet med en annan syntax
            //var resultSet = Enumerable.OrderBy(people, x => x.Name);

            foreach (var item in peopleList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }
}
