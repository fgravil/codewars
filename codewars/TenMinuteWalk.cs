using System;
using System.Collections.Generic;
using System.Text;

namespace codewars
{
    public class TenMinuteWalk
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10) return false;
            var eastCnt = 0;
            var westCnt = 0;
            var northCnt = 0;
            var southCnt = 0;

            foreach (var item in walk)
            {
                if (item == "e") eastCnt++;
                else if (item == "w") westCnt++;
                else if (item == "n") northCnt++;
                else if (item == "s") southCnt++;
            }
            return eastCnt == westCnt && northCnt == southCnt;
        }
    }
}
