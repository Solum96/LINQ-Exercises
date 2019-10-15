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

            countries.Add(sweden);
            countries.Add(norway);
            countries.Add(iceland);
            countries.Add(denmark);
            countries.Add(finland);
            countries.Add(belgium);
            countries.Add(germany);

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


            Console.ReadKey(); 
            


        }
    }
}
