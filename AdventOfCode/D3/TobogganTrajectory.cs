namespace AdventOfCode.D3
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class TobogganTrajectory
    {
        public virtual long CountTrees(string text)
        {
            var map = Map(text);
            var linesWithTree = Filter(map, 1, 3);
            return Reduce(linesWithTree);
        }

        public IEnumerable<SlopeLine> Map(string text)
        {
            return text.Split(Environment.NewLine)
                       .Select(line => new SlopeLine(line));
        }

        public IEnumerable<SlopeLine> Filter(IEnumerable<SlopeLine> items, int down, int right)
        {
            var x = 0;
            var encounteredLinesWithTree = new List<SlopeLine>();

            for (int i = 0; i < items.Count(); /*i +=down*/)
            {
                var slopeLine = items.ElementAt(i);

                if (slopeLine.ElementAt(x) == SlopeLineItem.Tree)
                {
                    encounteredLinesWithTree.Add(slopeLine);
                }

                x += right;

                i = i + down < items.Count() ? i + down : i + 1;
            }
            
            return encounteredLinesWithTree;
        }

        public long Reduce(IEnumerable<SlopeLine> items)
        {
            return items.Count();
        }

    }

    public enum SlopeLineItem
    {
        OpenSquare,
        Tree
    }

    public class SlopeLine
    {
        public IEnumerable<SlopeLineItem> Squares { get; }

        public SlopeLine(string text)
        {
            Squares = text.AsEnumerable()
                          .Select(x =>
                          {
                              switch (x)
                              {
                                  case '.':
                                      return SlopeLineItem.OpenSquare;
                                  case '#':
                                      return SlopeLineItem.Tree;
                                  default:
                                      throw new InvalidConstraintException($"{x} is not viable slope element");
                              }
                          });
        }

        public virtual SlopeLineItem ElementAt(int index)
        {
            return Squares.ElementAt(index % Squares.Count());
        }
    }
}