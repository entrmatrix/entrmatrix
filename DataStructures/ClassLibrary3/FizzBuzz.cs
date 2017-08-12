using System;
using System.Linq;

namespace AlgoLibrary
{
    /*  A simple math algorithm where the program prints from 1 to 100 and for multiples of 3, it prints Fizz and for multiples of five it prints Buzz instead of numbers. For numbers which are multiples of both 3 and 5, it prints FizzBuzz. 
     */
    public static class FizzBuzz
    {
        public static string GetFizzBuzz()
        {
            string fizzBuzzString = "";
            for (int i = 1; i < 101; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    fizzBuzzString += "FizzBuzz" + Environment.NewLine;
                else if (i % 3 == 0)
                    fizzBuzzString += "Fizz" + Environment.NewLine;
                else if (i % 5 == 0)
                    fizzBuzzString += "Buzz" + Environment.NewLine;
                else
                    fizzBuzzString += i.ToString() + Environment.NewLine;
            }
            return fizzBuzzString;
        }

        //  Call this in Program.cs to test
        //  Console.WriteLine(FizzBuzz.FizzBuzz());


        //  Another way to achieve same.
        public static void AnotherWayContainsDuplicate()
        {
            Enumerable.Range(1, 100).ToList()
               .ForEach(x =>
               {
                   Console.WriteLine("{0}{1}{2}",
                       x % 3 == 0 ? "Fizz" : "",
                       x % 5 == 0 ? "Buzz" : "",
                       x % 3 != 0 && x % 5 != 0 ? x.ToString() : "");
               });
        }
    }
}
