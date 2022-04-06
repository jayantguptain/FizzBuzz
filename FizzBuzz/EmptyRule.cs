namespace FizzBuzz
{
    public class EmptyRule : IRule
    {
        public string Run(double number)
        {
            return $"Divided {number} by 3\nDivided {number} by 5";
        }
    }
}
