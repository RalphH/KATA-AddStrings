using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AddStrings
{
    class Program
    {
        static void Main(string[] args)
        {            
        }
    }

    public static class Kata
    {
        public static int AddStrings(string numbers)
        {
            // return Regex.Split(numbers, ",+").Sum(int.Parse);
            return numbers.Split(',').Sum(int.Parse);
        }
    }
}
