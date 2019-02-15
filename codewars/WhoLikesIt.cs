using System;
using System.Collections.Generic;
using System.Text;

namespace codewars
{
    public class WhoLikesIt
    {
        public static string Likes(string[] name)
        {
            string text = " like this";
            int length = name.Length;

            if (length <= 1)
            {
                return (length == 0) ? "no one likes this"  : $"{name[0]} likes this";
            }

            string names = (length == 1)
                ? $"{name[0]}"
                : (length == 2)
                ? $"{name[0]} and {name[1]}"
                : (length == 3)
                ? $"{name[0]}, {name[1]} and {name[2]}"
                : $"{name[0]}, {name[1]} and {length - 2} others";

            return names + text;
        }
    }
}
