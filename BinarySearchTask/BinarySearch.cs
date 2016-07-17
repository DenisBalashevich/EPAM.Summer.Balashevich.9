using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTask
{
    /// <summary>
    /// This class find something somewhere
    /// </summary>
    public static class BinarySearch
    {
        /// <summary>
        /// Find T in array
        /// </summary>
        /// <typeparam name="T">Generic</typeparam>
        /// <param name="array">Array</param>
        /// <param name="key">Finding</param>
        /// <returns>position</returns>
        public static int Search<T>(T[] array, T key)
        {
            if (array == null)
                throw new ArgumentNullException();
            return Search(array, 0, array.Length - 1, key, null);
        }

        /// <summary>
        /// Find T in array
        /// </summary>
        /// <typeparam name="T">Generic</typeparam>
        /// <param name="array">Array</param>
        /// <param name="key">Finding</param>
        /// <param name="left">left param</param>
        /// <param name="right">right param</param>
        /// <returns>position</returns>
        public static int Search<T>(T[] array, int left, int right, T key)
        {
            if (array == null)
                throw new ArgumentNullException();
            return Search(array, left, right, key, null);
        }

        /// <summary>
        /// Find T in array
        /// </summary>
        /// <typeparam name="T">Generic</typeparam>
        /// <param name="array">Array</param>
        /// <param name="key">Finding</param>         
        /// <param name="comparer">Comparator</param>
        /// <returns>position</returns>

        public static int Search<T>(T[] array, T key, Comparison<T> comparer)
        {
            if (array == null)
                throw new ArgumentNullException();
            return Search(array, 0, array.Length - 1, key, new Adapter<T>(comparer));
        }

        /// <summary>
        /// Find T in array
        /// </summary>
        /// <typeparam name="T">Generic</typeparam>
        /// <param name="array">Array</param>
        /// <param name="key">Finding</param>         
        /// <param name="comparer">Comparator</param>
        /// <returns>position</returns>
        public static int Search<T>(T[] array, T key, IComparer<T> comparer) 
        {
            if (array == null)
                throw new ArgumentNullException();
            return Search(array, 0, array.Length - 1, key, comparer);
        }

        /// <summary>
        /// Find T in array
        /// </summary>
        /// <typeparam name="T">Generic</typeparam>
        /// <param name="array">Array</param>
        /// <param name="key">Finding</param>
        /// <param name="left">left param</param>
        /// <param name="right">right param</param>
        /// <param name="comparer">Comparator</param>
        /// <returns>Number position</returns>
        public static int Search<T>(T[] array, int left, int right, T key, IComparer<T> comparer)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (key == null)
                throw new ArgumentNullException();
            if (left > right)
                throw new ArgumentException();
            if (comparer == null)
                comparer = Comparer<T>.Default;

            while (right >= left)
            {
                int middle = (left + right) / 2;
                int comp = comparer.Compare(array[middle], key);
                if (comp > 0)
                {
                    right = middle - 1;
                }
                else if (comp < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }

        /// <summary>
        /// Adapt delegate to interface
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private class Adapter<T> : IComparer<T>
        {
            private readonly Comparison<T> comparison;

            public Adapter(Comparison<T> comparer)
            {
                comparison = comparer;
            }

            public int Compare(T a, T b)
            {
                return comparison(a, b);
            }
        }
    }
}
