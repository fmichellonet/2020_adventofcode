namespace AdventOfCode.D5
{
    using System.Collections.Generic;
    using System.Linq;

    public class BinaryBoardingP2 : BinaryBoarding
    {
        public override int Reduce(IEnumerable<BoardingPass> scannedPasses)
        {
            var minSeatId = 1 * 8 + 7;
            var maxSeatId = 126 * 8 + 7;

            var possiblePass = Enumerable.Range(minSeatId, maxSeatId)
                                         .Except(scannedPasses.Select(x => x.SeatId))
                                         .OrderBy(x => x)
                                         .ToArray();

           
            var dic = scannedPasses.ToDictionary(x => x.SeatId, x => x);

            for (int i = 1; i < possiblePass.Length; i++)
            {
                if (dic.ContainsKey(possiblePass[i] + 1) && dic.ContainsKey(possiblePass[i] - 1))
                {
                    return possiblePass[i];
                }
            }

            return -1;
        }
    }
}