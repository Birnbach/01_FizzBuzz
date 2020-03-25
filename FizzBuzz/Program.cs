using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public static List<string> MillNumbers(List<int> numbers)
        {
            string intoString;
            List<string> result = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 7 != 0)
                {
                    intoString = numbers[i].ToString();
                    if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0 || intoString.Contains("53") || intoString.Contains("35"))
                    {
                        result.Add("FizzBuzz");
                    }
                    else if (numbers[i] % 3 == 0)
                    {
                        result.Add("Fizz");
                    }
                    else if (numbers[i] % 5 == 0 || intoString.Contains("5"))
                    {
                        result.Add("Buzz");
                    }
                    else
                        result.Add(numbers[i].ToString());
                }

                else
                {
                    result.Add("Buzzinga");
                }
            }
            return result;
        }
    }
}