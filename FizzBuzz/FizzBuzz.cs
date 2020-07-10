using System;

namespace Fizz.Buzz
{
    public class FizzBuzz
    {
        public string GetFizzBuzz(int number)
        {
            var result = "";

            if (number % 3 == 0) 
            {
                result += "fizz";
            } 

            if (number % 5 == 0) 
            {
                result += "buzz";
            }

            if (result.Length == 0)
            {
                result = number.ToString();
            }

            return result;
        }
    }
}
