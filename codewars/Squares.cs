using System;
using System.Collections.Generic;
using System.Text;

namespace codewars
{
    public class Squares
    {
        public static bool IsSquare(int n)
        {
            if (n < 0) return false;
            if (n == 0) return true;

            for(int i = 0; i <= n / 2; i++)
            {
                if (i * i == n) return true;

                if (i * i > n) break;
            }

            return false;
        }

        public static bool IsSquare2(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }
    }
}
