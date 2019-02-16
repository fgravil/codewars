using System;
using System.Collections.Generic;
using System.Linq;

namespace codewars
{
    public class DescendingOrder
    {
        public static int Descending(int num)
        {
            List<int> numList = new List<int>();
            string numString = "";

            while (num > 0)
            {
                numList.Add(num % 10);
                num /= 10;
            }
            numList.Sort();
            numList.ForEach(val => numString = val + numString);

            return Convert.ToInt32(numString);
        }

        public static int Descending2(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }
    }
}