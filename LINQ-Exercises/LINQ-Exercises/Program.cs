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

            countries.Add(sweden);
            countries.Add(norway);
            countries.Add(iceland);
            countries.Add(denmark);
            countries.Add(finland);
            countries.Add(belgium);

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

            var query = from country in countries
                        orderby country.population descending
                        select country;

            foreach (var country in query)
            {
                Console.WriteLine(country.name);
            }
            Console.ReadKey();
            


        }
    }
}
