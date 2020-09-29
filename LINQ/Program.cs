using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQ
{
    class Program
    {
        static void Main()
        {
            Program a  = new Program();
            a.LearnLingOnComplexCollection();
            //LINQ- Language INtegrated Query

            int[] numbers ={12,34,23,67,445,65,10,89,144,135};
            // Method Syntax
            var result1= numbers.Where(num => num >50).Select(num => num);

            //Query expression Syntax
            var result2 = from num in numbers
                            where num > 50
                            select num;
            //Restrictions -where
            var result3 = from num in numbers
                            where num > 50 && num <70
                            select num;
            //Projections -select
            var result4 = from num in numbers
                            where num % 2==0
                            select num * num;
            // Ordering -orderby,orderby descending
            var result5 = from num in numbers
                            orderby num descending
                            select num;
            // Partitionong: take,skip
            var  result6 = numbers.Skip(5).Take(5);
            //Checks the first element and if first number is not even then next will be echecked.
            //result7=True
            var result7 = numbers.Any(num => num % 2 ==0);
            //result7=False
            var result8 = numbers.All(num => num % 2 ==0);
            // Generations:range
            var result9 = Enumerable.Range(1,1000);
            //Repeat Multiple times
            var result10 = Enumerable.Repeat("Hello World", 20);



            
        }
        void LearnLingOnComplexCollection()
        {

            Country c1 = new Country("Nepal","Kathmandu","Asia",124589);
            Country c2 = new Country("India","Delhi","Asia",45124589, DateTime.Parse("1947/11/1"));
            Country c3 = new Country("England","GB","Europe",58124589);
            Country c4 = new Country("Bhutan","Thimpu","Asia",124589);
            Country c5 = new Country("Russia","Moscow","Asia",124589, DateTime.Parse("1942/01/1"));
            Country c6 = new Country("Australia","Canberra","Australia",124589, DateTime.Parse("1927/10/1"));
            Country c7 = new Country("Argentina","Buenos Aires","South America",124589, DateTime.Parse("1827/10/1"));
            Country c8 = new Country("Australia","Canberra","Australia",124589, DateTime.Parse("1947/10/1"));
            Country c9 = new Country("Thailand","Bangkok","Asia",124589, DateTime.Parse("1925/10/1"));
            Country c10 = new Country("Tanzania","Dodoma","Africa",124589, DateTime.Parse("1877/10/1"));
            Country c11 = new Country("Tajikistan","Dushanbe","Asia",124589, DateTime.Parse("1837/10/1"));
            Country c12 = new Country("Taiwan","Taipei","Asia",124589, DateTime.Parse("1827/10/1"));
            Country c13 = new Country("Zimbabwe","Harare","Africa",124589, DateTime.Parse("1997/10/1"));
            Country c14 = new Country("Venezuela","Caracas","South America",124589, DateTime.Parse("1987/10/1"));
            Country c15 = new Country("Vatican City","Vatican City","Europe",1245, DateTime.Parse("1977/10/1"));
            Country c16 = new Country("Uzbekistan","Tashkent","Asia",124589);
            Country c17 = new Country("Uruguay","Montevideo","South America",124589, DateTime.Parse("1967/10/1"));
            Country c18 = new Country("United States","Washington, D.C.","North America",124589, DateTime.Parse("1957/10/1"));
            Country c19 = new Country("United Kingdom","London","Europe",1245, DateTime.Parse("1947/10/1"));
            Country c20 = new Country("United Arab Emirates ","Abu Dhabi","Asia",124589, DateTime.Parse("1937/10/1"));


	
            //Add 20 countries
            var countries = new List<Country> {c1,c2,c3,c4,c5,c6};
            //List all asian Country names
            var result11 = from country in countries
                            where country.Continent == "Asia"
                            select country.Name;
            //HW- List all asian country names which are never been invaded
            var result12 = from country in countries
                           where country.Continent == "Asia" && country.IndependenceDay == default
                           select country.Name;

            //Hw-List all europian countries in ascending order that has with population less than 500k
            var result13 = from country in countries
                            where country.Continent == "Europe" && country.Population < 500000
                            select country.Name;



            

            Console.WriteLine("Countries that have never  invaded are: ");
            foreach (var name in result12)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Europian countries that has population less than 500k in ascending order: ");
            foreach (var name in result13)
            {
                Console.WriteLine(name);
            }
        }

    }
}