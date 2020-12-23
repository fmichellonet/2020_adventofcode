namespace AdventOfCode.D3
{

    public class TobogganTrajectoryP2 : TobogganTrajectory
    {
        public override long CountTrees(string text)
        {
            var map = Map(text);
            var slope1 = Reduce(Filter(map, 1, 1));
            var slope2 = Reduce(Filter(map, 1, 3));
            var slope3 = Reduce(Filter(map, 1, 5));
            var slope4 = Reduce(Filter(map, 1, 7));
            var slope5 = Reduce(Filter(map, 2, 1));
            
            return slope1 * slope2 * slope3 * slope4 * slope5;
        }
    }
}