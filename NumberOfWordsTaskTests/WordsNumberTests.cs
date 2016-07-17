using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NumberOfWordsTask;
namespace NumberOfWordsTaskTests
{
    [TestFixture]
    public class WordsNumberTests
    {
        [TestCaseSource("GetParameters")]
        public double WordsNumber_Tests(string x)
        {
            return WordsNumber.WordFrequency(x);
        }
        public IEnumerable<TestCaseData> GetParameters()
        {
            yield return new TestCaseData("    Hello8888 a!@#$%^^&*worlds.    claas").Returns(4);
            yield return new TestCaseData("").Returns(0);
            yield return new TestCaseData(null).Throws(typeof(ArgumentNullException));
        }
    }
}
