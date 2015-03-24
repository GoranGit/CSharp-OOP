namespace Extensions.IEnumerableExtensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> input) where T : IComparable
        {
            T sum = default(T);
            if (Check(input))
            {
                foreach (var k in input)
                {
                    sum = (dynamic)k + sum;
                }
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> input) where T : IComparable
        {
            T product = (dynamic)1;
            if (Check(input))
            {
                foreach (var item in input)
                {
                    product = product * (dynamic)item;
                }
            }
            return product;
        }
        public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {

            T min = input.First();
            if (Check(input))
            {
                foreach (var item in input)
                {
                    if (min.CompareTo(item) > 0)
                        min = item;
                }

            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> input) where T : IComparable
        {
            T max = input.First();
            if (Check(input))
            {
                foreach (var item in input)
                {
                    if (max.CompareTo(item) < 0)
                        max = item;
                }

            }
            return max;
        }
        public static decimal Average<T>(this IEnumerable<T> input) where T : IComparable
        {
            long k = 0;
            decimal sum = 0;
            if (Check(input))
            {
                foreach (var item in input)
                {
                    sum += (dynamic)item;
                    k++;
                }
            }
            return sum / k;
        }
        private static bool Check<T>(IEnumerable<T> input) where T : IComparable
        {
            if (input.Count() == 0)
                throw new ArgumentNullException("No elements in collection!");
            if (typeof(T) == typeof(string))
                throw new ArgumentException("string can not be  summed");
            if (typeof(T) == typeof(string[]))
                throw new ArgumentException("string[] can not be  summed");
            if (typeof(T) == typeof(char))
                throw new ArgumentException("chars can not be  summed");
            return true;
        }

    }
}
