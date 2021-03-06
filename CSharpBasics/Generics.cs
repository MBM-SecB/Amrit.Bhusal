using System;
using System.Collections.Generic;

namespace LearningClasses
{
    public class Generic
    {
        void LearningList()
        {
            List<string> names = new List<string> { "Amrit Bhusal" };

            names.Add("Amrit Bhusal");
            names.Add("Amrit Bhusal");
            names.Add("Amrit Bhusal");
            names.Add("Amrit Bhusal");            

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        void LearningDictionary()
        {
            Dictionary<string, string> countryCapitals = new Dictionary<string, string>();

            countryCapitals.Add("Nepal", "Kathmandu");
            countryCapitals.Add("India", "Delhi");

            foreach (var countryCapital in countryCapitals)
            {
                Console.WriteLine(countryCapital.Value);
            }
        }
    }
}
