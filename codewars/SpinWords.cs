using System;

namespace codewars
{
    public class SpinWords
    {
        public static string SpinWords(string sentence)
        {
            string newSentence = "";
            var words = sentence.Split(" ");

            foreach (string word in words)
            {
                var modifiedWord = (word.Length >= 5) ? reverseWord(word) : word;
                newSentence = newSentence + " " + modifiedWord;
            }

            return newSentence.Substring(1);
        }

        public static string reverseWord(string word)
        {
            string newWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                newWord = newWord + word[i];
            }

            return newWord;
        }
    }
}
