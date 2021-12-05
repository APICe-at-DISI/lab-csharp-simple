namespace Indexers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A bidimentional map.
    /// </summary>
    /// <typeparam name="TKey1">the type of the first key.</typeparam>
    /// <typeparam name="TKey2">the type of the second key.</typeparam>
    /// <typeparam name="TValue">the type of the value.</typeparam>
    public interface IMap2D<TKey1, TKey2, TValue> : IEquatable<IMap2D<TKey1, TKey2, TValue>>
    {
        /// <summary>
        /// Gets the number of values in the map.
        /// </summary>
        int NumberOfElements { get; }

        /// <summary>
        /// The indexer used to access the value of the map.
        /// </summary>
        /// <param name="key1">the first key.</param>
        /// <param name="key2">the second key.</param>
        /// <returns>the value.</returns>
        TValue this[TKey1 key1, TKey2 key2] { get; set; }

        /// <inheritdoc cref="object.ToString" />
        /// <remarks><para>The string is a textual representation of the bidimentional map.</para></remarks>
        string ToString();

        /// <summary>
        /// Get the row of the map corresponding to the given first key.
        /// </summary>
        /// <param name="key1">the first key.</param>
        /// <returns>the row as a list of tuples.</returns>
        IList<Tuple<TKey2, TValue>> GetRow(TKey1 key1);

        /// <summary>
        /// Get the column of the map corresponding to the given second key.
        /// </summary>
        /// <param name="key2">the second key.</param>
        /// <returns>the column as list of tuples.</returns>
        IList<Tuple<TKey1, TValue>> GetColumn(TKey2 key2);

        /// <summary>
        /// Get all the values of the map as tuples.
        /// </summary>
        /// <returns>the values of the map.</returns>
        IList<Tuple<TKey1, TKey2, TValue>> GetElements();

        /// <summary>
        /// Fill the map with the values from the given enumerations.
        /// </summary>
        /// <param name="keys1">all the row keys.</param>
        /// <param name="keys2">all the column keys.</param>
        /// <param name="generator">the bifunction that generates the value given the couple of keys.</param>
        void Fill(IEnumerable<TKey1> keys1, IEnumerable<TKey2> keys2, Func<TKey1, TKey2, TValue> generator);
    }
}
