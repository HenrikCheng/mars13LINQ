using System;
using System.Linq;
using System.Collections.Generic;

namespace mars13_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
            new Person { Name = "Håkan", Age = 56 },
            new Person { Name = "Pontus", Age = 40 },
            new Person { Name = "Academy", Age = 4 }
            };

            var peopleList = people.OrderBy(p => p.Name);
            //exakt samma kodrad som ovan fast skrivet med en annan syntax
            //var resultSet = Enumerable.OrderBy(people, x => x.Name);

            foreach (var item in peopleList)
            {
                Console.WriteLine(item);
            }
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
