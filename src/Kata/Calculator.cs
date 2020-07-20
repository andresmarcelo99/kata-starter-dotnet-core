using System;
using System.Collections.Generic;
namespace Kata
{
    public class Calculator
    {
        public int Add(string numbers="")
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;                
            }

            int sum = 0;
            string[] delimiters = getDelimiters(numbers);
            string[] numbers_str = numbers.Split(delimiters, StringSplitOptions.None);
            foreach (var num in numbers_str)
            {
                if (int.TryParse(num, out int num_int))
                {
                    if (num_int < 0)
                    {
                        throw new Exception($"negatives not allowed: {num_int}");
                    }
                    sum += num_int;
                }
            }
            
            return sum;
        }

        public string[] getDelimiters(string numbers)
        {

            List<string> delimiters = new List<string> {",", "\n"};
            if (numbers.StartsWith("//"))
            {
                delimiters.Add(numbers[2].ToString());
            }

            return delimiters.ToArray();
        }
    }
}