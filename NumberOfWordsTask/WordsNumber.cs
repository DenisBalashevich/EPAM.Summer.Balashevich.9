using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfWordsTask
{
    /// <summary>
    /// Number of words in text
    /// </summary>
    public class WordsNumber
    {
        /// <summary>
        /// Number words finder
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>number f words</returns>
        public static int WordFrequency(string str)
        {
            if (ReferenceEquals(str, null))
                throw new ArgumentNullException();
            string[] strArr = ParseWord(str).Split(new char[] { ' ' });
            return WordsNum(strArr);
        }

        /// <summary>
        /// Method delete all symbols
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string without symbols</returns>
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

        /// <summary>
        /// words counter
        /// </summary>
        /// <param name="strArr">array of words</param>
        /// <returns>number of words in array</returns>
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
