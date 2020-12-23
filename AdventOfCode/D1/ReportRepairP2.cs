namespace AdventOfCode.D1
{
    using System;
    using System.Linq;

    public class ReportRepairP2
    {
        public double? ComputeFix(string text)
        {
            var items = Map(text);
            if (items.Length < 3)
            {
                return null;
            }

            var filteredItems = Filter(items, 2020);

            if (filteredItems == null)
            {
                return null;
            }

            return Reduce(filteredItems);
        }


        public double[] Map(string text)
        {
            return text.Split(Environment.NewLine)
                       .Select(item => double.Parse(item))
                       .ToArray();
        }

        public double[] Filter(double[] items, double match)
        {
            if (items.Length <= 2)
            {
                return null;
            }

            for (var i = 0; i < items.Length - 2; i++)
            {
                for (var j = i + 1; j < items.Length - 1; j++)
                {
                    for (var k = i + 2; k < items.Length; k++)
                    {
                        if (items[i] + items[j] + items[k] == match)
                        {
                            return new[] {items[i], items[j], items[k]};
                        }
                    }
                }
            }

            return null;
        }


        public double Reduce(double[] items)
        {
            return items.Aggregate((a, b) => a * b);
        }
    }
}