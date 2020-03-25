using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> results = new List<string>;
            Console.WriteLine("Hello World!");
            List<int> numbers = new List<int> { 1, 4532, 51, 31, 11531, 22354 };

            var results = FizzBuzzer.MillNumbers(numbers);
            results.ForEach(Console.WriteLine);
        }
    }
}
