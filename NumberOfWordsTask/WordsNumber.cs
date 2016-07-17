using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfWordsTask
{
    public class WordsNumber
    {
        public static int WordFrequency(string str)
        {
            if (ReferenceEquals(str, null))
                throw new ArgumentNullException();
            string[] strArr = ParseWord(str).Split(new char[] { ' ' });
            return WordsNum(strArr);
        }

        private static string ParseWord(string str)
        {
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (!char.IsLetter(ch[i]))
                    ch[i] = ' ';
            }
            return new string(ch);
        }

        private static int WordsNum(string[] strArr)
        {
            int wordsNum = 0;
            foreach (var s in strArr)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    wordsNum++;
                }
            }
            return wordsNum;
        }
    }
}
