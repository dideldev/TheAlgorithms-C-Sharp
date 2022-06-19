using System.Collections.Generic;

namespace Algorithms.Sorters.Comparison
{
    /// <summary>
    ///     Class that implements insertion sort algorithm.
    /// </summary>
    /// <remarks>
    /// More info on https://en.wikipedia.org/wiki/Insertion_sort.
    /// </remarks>
    /// <typeparam name="T">Type of array element.</typeparam>
    public class InsertionSorter<T> : IComparisonSorter<T>
    {
        /// <summary>
        ///     Sorts array using specified comparer,
        ///     internal, in-place, stable,
        ///     time complexity: O(n^2),
        ///     space complexity: O(1),
        ///     where n - array length.
        /// </summary>
        /// <param name="array">Array to sort.</param>
        /// <param name="comparer">Compares elements.</param>
        public void Sort(T[] array, IComparer<T> comparer)
        {
            for (int i = 1; i < array.Length; ++i)
            {
                T key = array[i];
                int j = i - 1;

                // Swap the key with the previous element on the array if
                // the order is wrong.
                while (j >= 0 && comparer.Compare(array[j], key) > 0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
            }
        }
    }
}
