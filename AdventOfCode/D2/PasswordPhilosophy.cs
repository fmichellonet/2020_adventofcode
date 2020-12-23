namespace AdventOfCode.D2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PasswordPhilosophy
    {
        public int CountValidPassword(string text)
        {
            var passwordsWithPolicy = Map(text);
            var filtered = Filter(passwordsWithPolicy);
            return Reduce(filtered);
        }

        public IEnumerable<PasswordWithPolicy> Map(string text)
        {
            return text.Split(Environment.NewLine)
                       .Select(line =>
                       {
                           var tokens = line.Split(' ');

                           var minOccu = int.Parse(tokens[0].Split('-')[0]);
                           var maxOccu = int.Parse(tokens[0].Split('-')[1]);
                           var letter = tokens[1].First();

                           return new PasswordWithPolicy
                           { Letter = letter, Occurrences = new Range(minOccu, maxOccu), Password = tokens[2] };
                       });
        }

        public virtual IEnumerable<PasswordWithPolicy> Filter(IEnumerable<PasswordWithPolicy> item)
        {
            return item.Where(x =>
            {
                var count = x.Password.Count(y => y == x.Letter);
                return x.Occurrences.Start.Value <= count && count <= x.Occurrences.End.Value;
            });
        }

        public int Reduce(IEnumerable<PasswordWithPolicy> items)
        {
            return items.Count();
        }
    }

    public class PasswordWithPolicy
    {
        public Range Occurrences;

        public char Letter;

        public string Password;
    }
}