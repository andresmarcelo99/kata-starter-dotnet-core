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
            return Int32.Parse(numbers);
        }
    }
}