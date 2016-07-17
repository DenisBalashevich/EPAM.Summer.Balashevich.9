using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BinarySearchTask;

namespace BinarySearchTest
{
    [TestFixture]
    public class BinarySearchTests
    {
        private int[] arr = new int[] { -100, -10, 0, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };

        [TestCaseSource("GetTwoParameters")]
        public double BinarySearch_2Parameters(int[] x, int y)
        {
            return BinarySearchTask.BinarySearch.Search<int>(x, y);
        }

        [TestCaseSource("GetTwoParameters")]
        public double BinarySearch_4Parameters(int[] x, int y)
        {
            return BinarySearchTask.BinarySearch.Search<int>(x, 0, x.Length-1, y);
        }


        public IEnumerable<TestCaseData> GetTwoParameters()
        {
            yield return new TestCaseData(arr, 1).Returns(4);
            yield return new TestCaseData(arr, -100).Returns(0);
            yield return new TestCaseData(arr, 0).Returns(2);
            yield return new TestCaseData(arr, 45455).Returns(-1);
            yield return new TestCaseData(null, 9).Throws(typeof(ArgumentNullException));
        }


    }

}
