namespace AdventOfCode.D2
{
    using System.Collections.Generic;
    using System.Linq;

    public class PasswordPhilosophyP2 : PasswordPhilosophy
    {
        
        public override IEnumerable<PasswordWithPolicy> Filter(IEnumerable<PasswordWithPolicy> item)
        {
            return item.Where(x =>
            {
                var first = x.Password[x.Occurrences.Start.Value - 1] == x.Letter ? 1 : 0;
                var second = x.Password[x.Occurrences.End.Value - 1] == x.Letter ? 1 : 0;

                return first + second == 1;
            });
        }

       
    }

}