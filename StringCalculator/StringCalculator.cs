using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            int sum = 0;
            var numberLists = numbers.Split(',');
            var negativeNumbers = new List<int>();

            foreach (var number in numberLists)
            {
                int.TryParse(number, out int num);

                if (num < 0)
                    negativeNumbers.Add(num);
                else 
                    sum += num;
            }

            if (negativeNumbers.Count > 0)
            {
                var negativesList = string.Join(',', negativeNumbers);
                var exceptionMessage = $"Negative numbers are not allowed: {negativesList}.";
                throw new ArgumentException(exceptionMessage);
            }

            return sum;
        }
    }
}
