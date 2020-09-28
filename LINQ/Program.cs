using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()

        {
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
            //Add 20 countries

            var countries = new List<Country> {c1,c2,c3,c4,c5,c6};

            //List all asian Country names
            var result1 = from country in countries
                            where country.Continent == "Asia"
                            select country.Name;

            //HW- List all asian country names which are never been invaded
            //Hw-List all europian countries in ascending order that has with population less than 500k
        }
    }
}
