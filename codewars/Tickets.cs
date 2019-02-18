using System;
using System.Collections.Generic;
using System.Text;

namespace codewars
{
    public class Tickets
    {
        public static string GetChange(int[] peopleInLine)
        {
            string notEnough = "NO";

            if (peopleInLine[0] > 25 || peopleInLine[1] > 25)
            {
                return notEnough;
            }

            for(int i = 3; i < peopleInLine.Length; i++)
            {
                var price = peopleInLine[i];
                if (price > 25)
                {
                    for (int j = 0; j < i; j++)
                    {
                        var exchange = price - peopleInLine[j];
                        if(exchange >= 25)
                        {
                            price = exchange;
                            peopleInLine[j] = 0;
                        }
                    }
                }
                if (price == 25) peopleInLine[i] = 25;
                else return notEnough;
            }

            return "YES";
        }
    }
}
