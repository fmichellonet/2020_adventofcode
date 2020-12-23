namespace AdventOfCode.D4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FluentValidation;

    public class PassportProcessing
    {
        private readonly AbstractValidator<Passport> _validator;

        public PassportProcessing(AbstractValidator<Passport> validator)
        {
            _validator = validator;
        }

        public int CountValidPassports(string text)
        {
            var passports = Map(text);
            var filteredPassports = Filter(passports);
            return Reduce(filteredPassports);
        }

        public IEnumerable<Passport> Map(string text)
        {
            return text.Split(Environment.NewLine + Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                       .Select(line =>
                       {
                           var kv = line.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                           var dic = kv.ToDictionary(s => s.Split(':')[0], s => s.Split(':')[1]);

                           return new Passport(dic);
                       });
        }

        public IEnumerable<Passport> Filter(IEnumerable<Passport> passports)
        {
            return passports.Where(x => _validator.Validate(x).IsValid);
        }

        public int Reduce(IEnumerable<Passport> passports)
        {
            return passports.Count();
        }
    }

    public class Passport
    {
        public Dictionary<string, string> KeysAndValues { get; }
        
        public Passport(Dictionary<string, string> keysValues)
        {
            KeysAndValues = keysValues;
        }

        public int? BirthYear => !int.TryParse(KeysAndValues.ContainsKey("byr") ? KeysAndValues["byr"] : null, out var birthYear) ? (int?) null : birthYear;

        public int? IssueYear => !int.TryParse(KeysAndValues.ContainsKey("iyr") ? KeysAndValues["iyr"] : null, out var issueYear) ? (int?)null : issueYear;

        public int? ExpirationYear => !int.TryParse(KeysAndValues.ContainsKey("eyr") ? KeysAndValues["eyr"] : null, out var expirationYear) ? (int?)null : expirationYear;

        public double? Height
        {
            get
            {
                if (!KeysAndValues.ContainsKey("hgt"))
                {
                    return null;
                }
                var str = KeysAndValues["hgt"];
                return !double.TryParse(str.Substring(0, str.Length - 2), out var height) ? (double?) null : height;
            }
        }

        public string HeightUnit => KeysAndValues.ContainsKey("hgt") ? KeysAndValues["hgt"].Substring(KeysAndValues["hgt"].Length - 2) : null;

        public string HairColor => KeysAndValues.ContainsKey("hcl") ? KeysAndValues["hcl"] : null;

        public string EyeColor => KeysAndValues.ContainsKey("ecl") ? KeysAndValues["ecl"] : null;

        public string PId => KeysAndValues.ContainsKey("pid") ? KeysAndValues["pid"] : null;
    }

    public class RequiredPassportValidator : AbstractValidator<Passport>
    {
        private readonly string[] _expectedKeys = { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" /*, "cid"*/ };

        public RequiredPassportValidator()
        {
            RuleFor(p => p.KeysAndValues).Must(kv => kv.Keys
                                                         .ToList()
                                                         .Intersect(_expectedKeys).Count() == _expectedKeys.Length);
        }
    }

    public class ValidFieldsPassportValidator : AbstractValidator<Passport>
    {
        private static readonly string[] ValidEyeColors = {"amb", "blu", "brn", "gry", "grn", "hzl", "oth"};

        private static readonly string[] ValidHeightUnit = { "cm", "in"};

        public ValidFieldsPassportValidator()
        {
            Include(new RequiredPassportValidator());

            RuleFor(p => p.BirthYear).GreaterThanOrEqualTo(1920).LessThanOrEqualTo(2002);

            RuleFor(p => p.IssueYear).GreaterThanOrEqualTo(2010).LessThanOrEqualTo(2020);

            RuleFor(p => p.ExpirationYear).GreaterThanOrEqualTo(2020).LessThanOrEqualTo(2030);

            RuleFor(p => p.Height).GreaterThanOrEqualTo(150).LessThanOrEqualTo(193).When(p => p.HeightUnit == "cm");

            RuleFor(p => p.Height).GreaterThanOrEqualTo(59).LessThanOrEqualTo(76).When(p => p.HeightUnit == "in");

            RuleFor(p => p.HeightUnit).Must(x => ValidHeightUnit.Contains(x));

            RuleFor(p => p.HairColor).Matches("#([0-9]|[a-f]){6}");

            RuleFor(p => p.EyeColor).Must(x => ValidEyeColors.Contains(x));

            RuleFor(p => p.PId).Matches("\\d{9}").Length(9);
        }
    }
}