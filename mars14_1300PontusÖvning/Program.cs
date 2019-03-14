using System;
using System.Linq;
using System.Collections.Generic;

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
            //Håkan och Pontus anekdot
            Random r = new Random();
            var slumpad = people
                .OrderBy(x => r.Next(1, 10000));

            Workplace[] company = new Workplace[]{
                new Workplace () {CompanyName = "Academy", WorkplaceID = 1},
                new Workplace () {CompanyName = "Google", WorkplaceID = 2},
                new Workplace () {CompanyName = "Apple", WorkplaceID = 3}
            };

            Console.WriteLine("3a");
            var lista = people
                .Where(x => x.Age > 30)
                //.OrderBy(x => x.Age)
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Age);
            //alternativt sätt att lösa uppgiften

            foreach (var item in lista)
            {
                Console.WriteLine($"name: {item.Name}, age {item.Age}");
            }
            Console.WriteLine("3b");
            var folkUnder30 = people.Count(x => x.Age < 30);
            Console.WriteLine(folkUnder30);

            Console.WriteLine("3c");
            var snittålder = people.Average(x => x.Age);
            Console.WriteLine(snittålder);

            Console.WriteLine("3d");
            var förstaNamnet = people.FirstOrDefault(x => x.Name == "Anna");
            Console.WriteLine(förstaNamnet.Name + ", " + förstaNamnet.Age);
            //f
            Console.WriteLine("Uppgift F");
            var joinList = people
                .Join(company, p => p.WorkplaceID, c => c.WorkplaceID, (p, c) => new { p.Name, c.CompanyName, c.WorkplaceID });
            foreach (var item in joinList)
            {
                Console.WriteLine($"Name: {item.Name}, arbetsplats {item.CompanyName}, ref nr: {item.WorkplaceID}");
            }

            Console.WriteLine("Uppgift G");
            var groupJoinList2 = company
                .GroupJoin(people, c => c.WorkplaceID, p => p.WorkplaceID, (c, p) => new { PN = c.CompanyName, Employees = p });
            foreach (var item in groupJoinList2)
            {
                Console.WriteLine($"Företagsnamn: {item.PN}, antal anställda: {item.Employees.Count()}");
                //foreach (var innerItem in item.Employees)
                //{
                //    Console.Write($"{innerItem.Name}, ");
                //}
                //Console.WriteLine();
            }
            Console.WriteLine("Uppgift E");
            var anställda = groupJoinList2
                .OrderByDescending(x => x.Employees.Count())
                .First();
            Console.WriteLine($"Företaget: {anställda.PN}, antal anställda: {anställda.Employees.Count()}");
        }
    }
}
