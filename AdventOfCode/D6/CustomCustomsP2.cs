namespace AdventOfCode.D6
{
    using System.Collections.Generic;
    using System.Linq;

    public class CustomCustomsP2 : CustomCustoms
    {
        public override int Reduce(IEnumerable<Group> groups)
        {
            return groups.Sum(g => g.YesForAllAnswers.Length);
        }
    }
}