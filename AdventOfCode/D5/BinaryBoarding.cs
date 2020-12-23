namespace AdventOfCode.D5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BinaryBoarding
    {
        public int GetHighestSeatid(string text)
        {
            var passes = Map(text);
            return Reduce(passes);
        }

        public IEnumerable<BoardingPass> Map(string text)
        {
            var decoder = new BoardingPassDecoder();

            return text.Split(Environment.NewLine)
                       .Select(line => decoder.Decode(line));
        }

        public virtual int Reduce(IEnumerable<BoardingPass> passes)
        {
            return passes.Max(x => x.SeatId);
        }
    }

    public class BoardingPass
    {

        public int Row { get; set; }
        public int Column { get; set; }

        public int SeatId { get; set; }

    }

    public class BoardingPassDecoder
    {
        private readonly Range _rows = new Range(0, 127);
        private readonly Range _columns = new Range(0, 7);

        public BoardingPass Decode(string binaryPass)
        {
            int row = _rows.Apply('F', 'B', binaryPass.Substring(0, 7)).Start.Value;
            int column = _columns.Apply('L', 'R', binaryPass.Substring(7, 3)).Start.Value;

            return new BoardingPass
            {
                Row = row,
                Column = column,
                SeatId = row * 8 + column
            };
        }
    }

    public static class RangeExtensions
    {

        public static Range Apply(this Range input, char lowerBound, char upperBound, string letters)
        {
            var result = input;
            foreach (var l in letters)
            {
                result = Apply(result, lowerBound, upperBound, l);
            }

            return result;
        }

        public static Range Apply(this Range input, char lowerBound, char upperBound, char letter)
        {
            int length = input .GetLength();

            if (letter == lowerBound)
            {
                return new Range(input.Start, input.Start.Value + length / 2 - 1);
            }

            if (letter == upperBound)
            {
                return new Range(input.Start.Value + length / 2, input.End);
            }

            throw new InvalidOperationException();
        }

        public static int GetLength(this Range input)
        {
            return input.End.Value - input.Start.Value + 1;
        }
    }
}