using System;
using System.Linq;

namespace mars14_1300PontusÖvning
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]{
                new Person () {Name = "Henrik", Age = 31, WorkplaceID = 1},
                new Person () {Name = "Elsa", Age = 28, WorkplaceID = 2},
                new Person () {Name = "Malin", Age = 23, WorkplaceID = 3},
                new Person () {Name = "Peter", Age = 51, WorkplaceID = 1},
                new Person () {Name = "Anna", Age = 35, WorkplaceID = 1},
                new Person () {Name = "Anna", Age = 51, WorkplaceID = 1},
                new Person () {Name = "Anna", Age = 79, WorkplaceID = 1},
                new Person () {Name = "Henrik", Age = 40, WorkplaceID = 1},
            };

            Workplace[] company = new Workplace[]{
                new Workplace () {CompanyName = "Academy", WorkplaceID = 1},
                new Workplace () {CompanyName = "Google", WorkplaceID = 2},
                new Workplace () {CompanyName = "Apple", WorkplaceID = 3}
            };

            var lista = people
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Age)
                .OrderBy(x => x.Name);

            foreach (var item in lista)
            {
                Console.WriteLine($"name: {item.Name}, age {item.Age}");
            }

            var folkUnder30 = people.Count(x => x.Age < 30);
            Console.WriteLine(folkUnder30);

            var snittålder = people.Average(x => x.Age);
            Console.WriteLine(snittålder);

            var förstaNamnet = people.FirstOrDefault(x => x.Name == "Anna");
            Console.WriteLine(förstaNamnet.Name + ", " + förstaNamnet.Age);

            var joinList = people.Join(company, p => p.WorkplaceID, c => c.WorkplaceID, (p, c) => new { p.Name, c.CompanyName, c.WorkplaceID });
            foreach (var item in joinList)
            {
                Console.WriteLine($"Name: {item.Name}, arbetsplats {item.CompanyName}, ref nr: {item.WorkplaceID}");
            }

            var groupJoinList = people.GroupJoin(company, p => p.WorkplaceID, c => c.WorkplaceID, (p, k) => new { PersonName = p.Name, PN = k } );
            foreach (var item in groupJoinList)
            {
                Console.Write(item.PersonName);
                foreach (var innerItem in item.PN)
                {
                    Console.WriteLine(innerItem.CompanyName);
                }
            }
            Console.WriteLine();

            var groupJoinList2 = company.GroupJoin(people, c => c.WorkplaceID, p => p.WorkplaceID, (c, p) => new { PN = c.CompanyName , PersonName = p});
            foreach (var item in groupJoinList2)
            {
                Console.WriteLine(item.PN);
                foreach (var innerItem in item.PersonName)
                {
                    Console.Write($"{innerItem.Name}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
