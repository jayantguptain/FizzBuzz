namespace FizzBuzz
{
    public class BuzzRule : IRule
    {
        public string Run(double number)
        {
            return (number % 5) == 0 ? "Buzz" : string.Empty;
        }
    }
}
