namespace FizzBuzz
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            //-- currently values are based on question coding-exercise-Fizz-Buzz
            ////-- but it can work with any array of numbers
            var array = new string[7] { "1", "3", "5", "", "15", "A", "23" };
            
            var rules = new List<IRule>
            {
                new FizzRule(),
                new BuzzRule(),
            };

            new FizzBuzz(rules).Play(array);

            Console.ReadKey();
        }
    }
}
