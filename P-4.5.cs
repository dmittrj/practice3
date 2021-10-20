using System;
using System.Collections.Generic;

namespace Practice_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> countryLookup = new Dictionary<int, String>();

            countryLookup[44] = "United Kingdom"; 
            countryLookup[33] = "France"; 
            countryLookup[31] = "Netherlands"; 
            countryLookup[55] = "Brazil"; 
            countryLookup[64] = "New Zealand";

            foreach (KeyValuePair<int, String> item in countryLookup)
            {
                int code = item.Key;
                string country = item.Value;
                Console.WriteLine("Code {0} = {1}", code, country);
            }
        }
    }
}
