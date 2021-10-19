using System;
using System.Text.RegularExpressions;

namespace Practice_3._2
{
    class Program
    {
        static bool IsPhone(string s)
        {
            return Regex.IsMatch(s, @"^\(?\d{ 3}\)?[\s\-]?\d{ 3}\-?\d{ 4}$");
        }
        static bool IsZip(string s)
        {
            return Regex.IsMatch(s, @" ^\d{5}(\-\d{4})?$");
        }
        static string ReformatPhone(string s)
        {
            Match m = Regex.Match(s, @" ^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$");
            return String.Format("({0}) {1}-{2}", m.Groups[1], m.Groups[2], m.Groups[3]);
        }
        static void Main(string[] args)
        {
        }
    }
}
