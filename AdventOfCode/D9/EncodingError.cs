namespace AdventOfCode.D9
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EncodingError
    {
        public long? GetFirstNonSumOfPreamble(string text, int preambleLength)
        {
            var all = Map(text);

            return Reduce(all, preambleLength);
        }


        public IEnumerable<long> Map(string text)
        {
            return text.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                       .Select(long.Parse);
        }

        public long? Reduce(IEnumerable<long> all, int preambleLength)
        {
            var array = all.ToArray();
            int iteration = 0;
            for (int i = preambleLength; i < array.Length; i++, iteration++)
            {
                var preamble = array.Skip(iteration).Take(preambleLength);
                var valids = preamble.Combinate((a, b) => a + b);

                if (!valids.Contains(array[i]))
                    return array[i];
            }

            return null;
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Combinate<T>(this IEnumerable<T> elements, Func<T, T, T> aggregate)
        {
            return elements.SelectMany((e, i) =>
                elements.Skip(i + 1)
                        .Select(c => aggregate(e, c)));
        }

    }
}