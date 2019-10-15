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

            countries.Add(sweden);
            countries.Add(norway);
            countries.Add(iceland);
            countries.Add(denmark);
            countries.Add(finland);
            countries.Add(belgium);
            countries.Add(germany);
            countries.Add(greece);

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
            Console.ReadKey(); 
            


        }
    }
}
