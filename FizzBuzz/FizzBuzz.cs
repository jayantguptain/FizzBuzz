namespace FizzBuzz
{
    using System;
    using System.Collections.Generic;

    public class FizzBuzz
    {
        private List<IRule> _rules;

        public FizzBuzz(List<IRule> rules)
        {
            _rules = rules ?? new List<IRule>();
        }

        public void Play(string[] array)
        {
            foreach (var item in array)
            {
                var output = string.Empty;
                if (!Double.TryParse(item, out double result))
                    output = "Invalid Item";
                else
                {
                    foreach (var rule in _rules) { output += rule.Run(result); }
                    if (output == string.Empty) { output += new EmptyRule().Run(result); }
                }

                Console.WriteLine(output);
            }
        }
    }
}
