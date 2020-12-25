namespace AdventOfCode.D6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomCustoms
    {
        public int GetSumOfCount(string text)
        {
            var map = Map(text);
            return Reduce(map);
        }

        public IEnumerable<Group> Map(string text)
        {
            return text.Split(Environment.NewLine + Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                       .Select(group =>
                       {
                           return new Group(group.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                                                 .Select(person => new Person(person?.AsEnumerable().ToArray()))
                           );
                       });
        }

        public virtual int Reduce(IEnumerable<Group> groups)
        {
            return groups.Sum(g => g.CumulatedYesAnswers.Length);
        }
    }

    public class Group
    {
        private readonly IEnumerable<Person> _persons;

        public Group(IEnumerable<Person> persons)
        {
            _persons = persons;
        }

        public char[] CumulatedYesAnswers
        {
            get
            {
                return _persons.SelectMany(p => p.YesAnswers)
                               .Distinct()
                               .ToArray();
            }
        }

        public char[] YesForAllAnswers
        {
            get
            {
                var res = _persons.SelectMany(p => p.YesAnswers)
                                  .GroupBy(x => x, (c, chars) => new KeyValuePair<int, char>(chars.Count(), c));

                return res.Where(x => x.Key == _persons.Count())
                          .Select(x => x.Value)
                          .ToArray();
            }
        }
    }

    public class Person
    {
        public Person(char[] yesAnswers)
        {
            YesAnswers = yesAnswers;
        }

        public char[] YesAnswers { get; }
    }
}