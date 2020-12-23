namespace AdventOfCode.D1
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class ReportRepair
    {
        public double? ComputeFix(string text)
        {
            var items = ArrayFromText(text).ToArray();
            if (items.Length < 2)
            {
                return null;
            }

            var pair = GetPairThatMatches(items, 2020);

            if (!pair.HasValue)
            {
                return null;
            }

            return pair.Value.Key * pair.Value.Value;
        }


        public IEnumerable<double> ArrayFromText(string text)
        {
            return text.Split(Environment.NewLine)
                       .Select(item => double.Parse(item));
        }

        public KeyValuePair<double, double>? GetPairThatMatches(IEnumerable<double> items, double match)
        {
            var enumerable = items as double[] ?? items.ToArray();

            if (enumerable.Length < 2)
            {
                throw new InvalidConstraintException("we need at least 2 items");
            }

            for (int i = 0; i < enumerable.Length -1; i++)
            {
                for (int j = i + 1; j < enumerable.Length; j++)
                {
                    if(enumerable[i] + enumerable[j] == match)
                        return new KeyValuePair<double, double>(enumerable[i], enumerable[j]);
                }
            }

            return null;
        }
    }
}