using System;

namespace Arrays
{
    /// <summary>
    /// Use these methods as examples for implementing 
    /// </summary>
    class Examples
    {
        /// <summary>
        /// Finds the maximum integer into an array of integers.
        /// Returns <see cref="int.MinValue"/> in case of empty array.
        /// </summary>
        /// <param name="array">an <see cref="Array"/> of <see cref="int"/></param>
        /// <returns>the maximum <see cref="int"/> in the <paramref name="array"/>, or <see cref="int.MinValue"/> if the
        /// <paramref name="array"/> is empty </returns>
        /// <exception cref="NullReferenceException">if the provided <paramref name="array"/> is <c>null</c></exception>
        public static int Max(int[] array)
        {
            var max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                var current = array[i];
                if (current > max)
                {
                    max = current;
                }
            }
            return max;
        }
        
        /// <summary>
        /// Sorts a given array of integers from the lowest one to the highest one.
        /// </summary>
        /// <remarks>This method alters the input array in such a way that the original ordering is lost.</remarks>
        /// <param name="array">an <see cref="Array"/> of <see cref="int"/> to be sorted</param>
        /// <exception cref="NullReferenceException">if the provided <paramref name="array"/> is <code>null</code></exception>
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j + 1] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}