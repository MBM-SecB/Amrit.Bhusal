using System;
namespace LearningClass
{
    public class Country
    {
        public string Name { get; set; }

        public int Population { get; set; }


        //Default Constructor-parameter less
        public Country()
        {

        }

        //Parameterized Constructor
        public Country(string name)
        {
            Name =name;
        }

         public Country(string name, int population)
        {
            Name =name;
            Population =population;
        }

    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal");
            Country country3 = new Country("Nepal",12456);

        
        }
    }
}