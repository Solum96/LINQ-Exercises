using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>();
            Country sweden = new Country("Sverige", "Stockholm", 10.07, 450295);
            Country norway = new Country("Norge", "Oslo", 5.27, 323802);
            Country iceland = new Country("Island", "Reykyavik", 0.33, 102775);
            Country denmark = new Country("Danmark", "Köpenhamn", 5.75, 42931);
            Country finland = new Country("Finland", "Helsingfors", 5.51, 338424);
            Country belgium = new Country("Belgien", "Bryssel", 11.30, 30528);
            Country germany = new Country("Tyskland", "Berlin", 82.18, 357168);
            Country greece = new Country("Grekland", "Aten", 11.18, 131957);
            Country monoglia = new Country("Mongoliet", "Kuala Lumpur", 3.08, 1566000);
            Country france = new Country("Frankrike", "Paris", 66.99, 640679);
            Country niue = new Country("Niue", "Alofi", 0.0016, 261);

            countries.Add(sweden);
            countries.Add(norway);
            countries.Add(iceland);
            countries.Add(denmark);
            countries.Add(finland);
            countries.Add(belgium);
            countries.Add(germany);
            countries.Add(greece);
            countries.Add(monoglia);
            countries.Add(france);
            countries.Add(niue);
            /* Övning 2
                var query = from country in countries
                        where country == countries.First() || country == countries.Last()
                        select country;


            foreach (var i in query)
            {
                Console.WriteLine(i.name);
            } */

            /* ÖVNING 3
            var query = from names in countries
                        orderby names.name ascending
                        select names;

            foreach (var country in query)
            {
                Console.WriteLine(country.name);
            } */

            /* ÖVNING 4
            var query = from country in countries
                        orderby country.population descending
                        select country;

            foreach (var country in query)
            {
                Console.WriteLine(country.name);
            } */


            /* ÖVNING 5
            var query = from country in countries
                        orderby country.population descending
                        select country;

            Console.WriteLine(query.First().population); */

            /* ÖVNING 6
            var query = from country in countries
                        select country.area;

            var query2 = from country in countries
                         where country.area < query.Average() // Kan bytas ut mot countries.Average((c) => c.area)
                         select country;

            Console.WriteLine(query.Average());
            foreach (var item in query2)
            {
                Console.WriteLine(item.name);
            } */

            /* ÖVNING 7
            var query = from country in countries
                        where country.population < 5
                        select country;
            foreach (var item in query)
            {
                Console.WriteLine(item.name);
            } */

            /* ÖVNING 8
            var query1 = from country in countries
                         where country.area > 1000
                         select country;

            var query2 = from country in countries
                         where country.area > 10000
                         select country;

            var query3 = from country in countries
                         where country.area > 100000
                         select country;

            Console.WriteLine(">1000 = " + query1.Count());
            Console.WriteLine(">10000 = " + query2.Count());
            Console.WriteLine(">100000 = " + query3.Count()); */

            /* ÖVNING 9
            var query = from country in countries
                        where country.capital[0] == country.name[0]
                        select country;

            foreach (var item in query)
            {
                Console.WriteLine(item.name);
            } */

            /* ÖVNING 10
            var query = from country in countries
                        where country.name.Count() > country.capital.Count()
                        select country;

            foreach (var item in query)
            {
                Console.WriteLine($"Namn: {item.name}. Huvudstad: {item.capital}.");
            } */

            /* ÖVNING 11
            var query = from country in countries
                        orderby country.population ascending
                        select country;

            var fiveFirst = query.Take(5);
            foreach (var item in fiveFirst)
            {
                Console.WriteLine(item.name + item.population);
            } */

            /* ÖVNING 12
            var query = from country in countries
                        orderby country.population
                        where country.population > 7
                        select country;

            var threeFirst = query.Take(3);

            foreach (var item in threeFirst)
            {
                Console.WriteLine(item.name + item.population);
            } */

            /* ÖVNING 13
            var query = from country in countries
                        orderby country.name ascending
                        where country.area > 500000
                        select country;
            var threeFirst = query.Take(3);

            foreach (var item in threeFirst)
            {
                Console.WriteLine(item.name);
            } */

            /* ÖVNING 14
            var query = from country in countries
                        orderby country.name ascending
                        group country by country.name[0];

            foreach (var item in query)
            {
                Console.WriteLine(item.Key);
                foreach (var i in item)
                {
                    Console.WriteLine(i.name);
                }
            } */

            /* ÖVNING 15
            var zeroMil = from country in countries
                              where Math.Round(country.population, 0) < 1 // 0 Million
                              select country;

            var fiveMil = from country in countries
                              where Math.Round(country.population, 0) == 5 // 5 Million
                              select country;

            var tenMil = from country in countries
                              where Math.Round(country.population, 0) == 10 // 10 Million
                              select country;

            Console.WriteLine("0 Million:");
            foreach (var item in zeroMil)
            {
                Console.WriteLine("- " + item.name);
            }
            Console.WriteLine("5 Million");
            foreach (var item in fiveMil)
            {
                Console.WriteLine("- " + item.name);
            }
            Console.WriteLine("10 Million");
            foreach (var item in tenMil)
            {
                Console.WriteLine("- " + item.name);
            } */

            /* ÖVNING 16ab
            var query = from country in countries
                        select country;

            foreach (var item in query)
            {
                Console.WriteLine(item.name + "s trångboddhet:  " + (Math.Round(item.population * 1000000 / item.area, 2)) + " person/km^2");
            } */

            /* ÖVNING 17
            var query = from country in countries
                        orderby new string(country.capital.Reverse().ToArray()) ascending
                        select country;
            foreach (var item in query)
            {
                Console.WriteLine(item.name);
            } */

            /* ÖVNING 18
            var query = from country in countries
                        orderby country.area ascending
                        select country;

            var smallSix = query.Take(6);
            var bigThree = query.Reverse().Take(3);

            Console.WriteLine(smallSix.Sum((c) => c.population));
            Console.WriteLine(bigThree.Sum((c) => c.population)); */

            var query = from country in countries
                        where country.name.Count() >= 7
                        select country;

            Console.WriteLine(query.Sum((c) => c.population));

            Console.ReadKey(); 

        }
    }
}
