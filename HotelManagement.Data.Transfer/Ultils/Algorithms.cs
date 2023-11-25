namespace HotelManagement.Algorithms
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    public static class AlgorithmsExtensions
    {
        #region Helpers

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void CheckNotNull<T>(T o, string paramName)
        {
            if (o is null) throw new ArgumentNullException(paramName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void CheckRange(int length, int index, int count)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
            if (index + count > length) throw new ArgumentOutOfRangeException(nameof(index) + "|" + nameof(count));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void CheckComparable<T>(string paramName)
        {
            if (!typeof(IComparable<T>).IsAssignableFrom(typeof(T)))
                throw new ArgumentNullException(paramName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Comparer<T> ComparerOf<T>(Comparison<T> comparison)
            => comparison == null ? null : Comparer<T>.Create(comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Comparer<T> ComparerOf<T>(IComparer<T> comparer)
            => comparer is Comparer<T> c ? c : comparer is null ? null : Comparer<T>.Create(comparer.Compare);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Comparison<T> CreateComparison<T>()
            => typeof(AlgorithmsExtensions).GetMethod(nameof(Comparison))
            .MakeGenericMethod(typeof(T)).CreateDelegate<Comparison<T>>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int Comparison<T>(T x, T y) where T : IComparable<T>
            => x == null ? (y == null ? 0 : -1) : (y == null ? 1 : x.CompareTo(y));

        #endregion
        #region BinarySearch

        public static int BinarySearch<T>(this IList<T> src, T item) where T : IComparable<T>
        {
            if (src is T[] array) return Array.BinarySearch(array, item);
            if (src is List<T> list) return list.BinarySearch(item);
            if (src is ArrayList arrayList) return arrayList.BinarySearch(item);

            CheckNotNull(src, nameof(src));
            return UncheckedBinarySearch(src, 0, src.Count - 1, item, Comparison);
        }

        public static int BinarySearch<T>(this IList<T> src, int index, int count, T item) where T : IComparable<T>
        {
            if (src is T[] array) return Array.BinarySearch(array, index, count, item);
            if (src is List<T> list) return list.BinarySearch(index, count, item, null);
            if (src is ArrayList arrayList) return arrayList.BinarySearch(index, count, item, null);

            CheckNotNull(src, nameof(src));
            CheckRange(src.Count, index, count);
            return UncheckedBinarySearch(src, index, index + count - 1, item, Comparison);
        }

        public static int BinarySearch<T>(this IList<T> src, T item, Comparison<T> comparison)
        {
            if (src is T[] array) return Array.BinarySearch(array, item, ComparerOf(comparison));
            if (src is List<T> list) return list.BinarySearch(item, ComparerOf(comparison));
            if (src is ArrayList arrayList) return arrayList.BinarySearch(item, ComparerOf(comparison));

            CheckNotNull(src, nameof(src));
            if (comparison == null)
            {
                CheckComparable<T>(nameof(comparison));
                comparison = CreateComparison<T>();
            }
            return UncheckedBinarySearch(src, 0, src.Count - 1, item, comparison);
        }

        public static int BinarySearch<T>(this IList<T> src, int index, int count, T item, Comparison<T> comparison)
        {
            if (src is T[] array) return Array.BinarySearch(array, index, count, item, ComparerOf(comparison));
            if (src is List<T> list) return list.BinarySearch(index, count, item, ComparerOf(comparison));
            if (src is ArrayList arrayList) return arrayList.BinarySearch(index, count, item, ComparerOf(comparison));

            CheckNotNull(src, nameof(src));
            CheckRange(src.Count, index, count);
            if (comparison is null)
            {
                CheckComparable<T>(nameof(comparison));
                comparison = CreateComparison<T>();
            }
            return UncheckedBinarySearch(src, index, index + count - 1, item, comparison);
        }

        public static int BinarySearch<T>(this IList<T> src, T item, IComparer<T> comparer)
        {
            if (src is T[] array) return Array.BinarySearch(array, item, comparer);
            if (src is List<T> list) return list.BinarySearch(item, comparer);
            if (src is ArrayList arrayList) return arrayList.BinarySearch(item, ComparerOf(comparer));

            CheckNotNull(src, nameof(src));
            Comparison<T> comparison;
            if (comparer is null)
            {
                CheckComparable<T>(nameof(comparer));
                comparison = CreateComparison<T>();
            }
            else comparison = comparer.Compare;
            return UncheckedBinarySearch(src, 0, src.Count - 1, item, comparison);
        }

        public static int BinarySearch<T>(this IList<T> src, int index, int count, T item, IComparer<T> comparer)
        {
            if (src is T[] array) return Array.BinarySearch(array, index, count, item, comparer);
            if (src is List<T> list) return list.BinarySearch(index, count, item, comparer);
            if (src is ArrayList arrayList) return arrayList.BinarySearch(index, count, item, ComparerOf(comparer));

            CheckNotNull(src, nameof(src));
            CheckRange(src.Count, index, count);
            Comparison<T> comparison;
            if (comparer is null)
            {
                CheckComparable<T>(nameof(comparer));
                comparison = CreateComparison<T>();
            }
            else comparison = comparer.Compare;
            return UncheckedBinarySearch(src, 0, index + count - 1, item, comparison);
        }

        private static int UncheckedBinarySearch<T>(IList<T> src, int startIndex, int endIndex, T item, Comparison<T> comparison)
        {
            for (int i, r; startIndex <= endIndex;)
            {
                i = startIndex + (endIndex - startIndex) / 2;
                r = comparison(src[i], item);
                if (r < 0) startIndex = i + 1;
                else if (r > 0) endIndex = i - 1;
                else return i;
            }
            return ~startIndex;
        }

        #endregion
        #region MergeSort

        public static void MergeSort<T>(this IList<T> src) where T : IComparable<T>
        {
            CheckNotNull(src, nameof(src));
            UncheckedMergeSort(src, 0, src.Count - 1, Comparison);
        }

        public static void MergeSort<T>(this IList<T> src, int index, int count) where T : IComparable<T>
        {
            CheckNotNull(src, nameof(src));
            CheckRange(src.Count, index, count);
            UncheckedMergeSort(src, index, index + count - 1, Comparison);
        }

        public static void MergeSort<T>(this IList<T> src, Comparison<T> comparison)
        {
            CheckNotNull(src, nameof(src));
            if (comparison is null)
            {
                CheckComparable<T>(nameof(comparison));
                comparison = CreateComparison<T>();
            }
            UncheckedMergeSort(src, 0, src.Count - 1, comparison);
        }

        public static void MergeSort<T>(this IList<T> src, int index, int count, Comparison<T> comparison)
        {
            CheckNotNull(src, nameof(src));
            CheckRange(src.Count, index, count);
            if (comparison is null)
            {
                CheckComparable<T>(nameof(comparison));
                comparison = CreateComparison<T>();
            }
            UncheckedMergeSort(src, index, index + count - 1, comparison);
        }

        public static void MergeSort<T>(this IList<T> src, IComparer<T> comparer)
        {
            CheckNotNull(src, nameof(src));
            Comparison<T> comparison;
            if (comparer is null)
            {
                CheckComparable<T>(nameof(comparer));
                comparison = CreateComparison<T>();
            }
            else comparison = comparer.Compare;
            UncheckedMergeSort(src, 0, src.Count - 1, comparison);
        }

        public static void MergeSort<T>(this IList<T> src, int index, int count, IComparer<T> comparer)
        {
            CheckNotNull(src, nameof(src));
            CheckRange(src.Count, index, count);
            Comparison<T> comparison;
            if (comparer is null)
            {
                CheckComparable<T>(nameof(comparer));
                comparison = CreateComparison<T>();
            }
            else comparison = comparer.Compare;
            UncheckedMergeSort(src, index, index + count - 1, comparison);
        }

        private static void UncheckedMergeSort<T>(IList<T> src, int startIndex, int endIndex, Comparison<T> comparison)
        {
            if (startIndex == endIndex) return;
            int count = (endIndex - startIndex) / 2 + 1;
            PreAllocatedUncheckedMergeSort(src, startIndex, endIndex, new T[count], comparison);
        }

        private static void PreAllocatedUncheckedMergeSort<T>(IList<T> src, int startIndex, int endIndex, T[] temporary, Comparison<T> comparison)
        {
            if (startIndex == endIndex) return;
            int di = (endIndex - startIndex) / 2, i = startIndex + di;
            if (startIndex < i) PreAllocatedUncheckedMergeSort(src, startIndex, i, temporary, comparison);
            if (++i < endIndex) PreAllocatedUncheckedMergeSort(src, i, endIndex, temporary, comparison);
            for (int j = 0, k = startIndex; j <= di;)
                temporary[j++] = src[k++];
            int l = 0, m = i, n = startIndex;
            while (l <= di && m <= endIndex)
                src[n++] = comparison(temporary[l], src[m]) <= 0 ? temporary[l++] : src[m++];
            while (l <= di) src[n++] = temporary[l++];
        }

        #endregion
        #region Sort

        public static void Sort<T>(this IList<T> src) where T : IComparable<T>
        {
            if (src is T[] array) Array.Sort(array);
            else if (src is List<T> list) list.Sort();
            else if (src is ArrayList arrayList) arrayList.Sort();
            else MergeSort(src);
        }

        public static void Sort<T>(this IList<T> src, int index, int count) where T : IComparable<T>
        {
            if (src is T[] array) Array.Sort(array, index, count);
            else if (src is List<T> list) list.Sort(index, count, null);
            else if (src is ArrayList arrayList) arrayList.Sort(index, count, null);
            else MergeSort(src, index, count);
        }

        public static void Sort<T>(this IList<T> src, Comparison<T> comparison)
        {
            if (src is T[] array) Array.Sort(array, comparison);
            else if (src is List<T> list) list.Sort(comparison);
            else if (src is ArrayList arrayList) arrayList.Sort(ComparerOf(comparison));
            else MergeSort(src, comparison);
        }

        public static void Sort<T>(this IList<T> src, int index, int count, Comparison<T> comparison)
        {
            if (src is T[] array) Array.Sort(array, index, count, ComparerOf(comparison));
            else if (src is List<T> list) list.Sort(index, count, ComparerOf(comparison));
            else if (src is ArrayList arrayList) arrayList.Sort(index, count, ComparerOf(comparison));
            else MergeSort(src, index, count, comparison);
        }

        public static void Sort<T>(this IList<T> src, IComparer<T> comparer)
        {
            if (src is T[] array) Array.Sort(array, comparer);
            else if (src is List<T> list) list.Sort(comparer);
            else if (src is ArrayList arrayList) arrayList.Sort(ComparerOf(comparer));
            else MergeSort(src, comparer);
        }

        public static void Sort<T>(this IList<T> src, int index, int count, IComparer<T> comparer)
        {
            if (src is T[] array) Array.Sort(array, index, count, comparer);
            else if (src is List<T> list) list.Sort(index, count, comparer);
            else if (src is ArrayList arrayList) arrayList.Sort(index, count, ComparerOf(comparer));
            else MergeSort(src, index, count, comparer);
        }

        #endregion

        #region BinarySearchBased

        public static BigInteger MinimumUnusedID(this IList<BigInteger> ids, BigInteger startId)
        {
            // begin linq-based
            //  IEnumerable<ulong> q = from id in ids join id2 in ids on id equals id2 + 1 select id;
            //  return (from id in ids where !q.Contains(id) select id).FirstOrDefault(defaultId - 1) + 1;
            // end linq-based
            // modified binary search

            int startIndex = ids.BinarySearch(startId);
            if (startIndex < 0) return startId;
            int endIndex = ids.Count - 1, i;
            BigInteger endId = ids[endIndex], curId;
            while (endIndex - startIndex > 1)
            {
                i = startIndex + (endIndex - startIndex) / 2;
                curId = ids[i];
                if (i - startIndex != (long)(curId - startId))
                {
                    endIndex = i;
                    endId = ids[endIndex];
                }
                else if (endIndex - i != (long)(endId - curId))
                {
                    startIndex = i;
                    startId = ids[startIndex];
                }
                else return endId + 1;
            }
            return startId + 1;
        }

        #endregion
    }
}
