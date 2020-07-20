using System;

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
            string[] numbers_str = numbers.Split(',');
            foreach (var num in numbers_str)
            {
                if (int.TryParse(num, out int num_int))
                {
                    sum += num_int;
                }
            }
            
            return sum;
        }
    }
}