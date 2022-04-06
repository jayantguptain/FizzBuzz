namespace FizzBuzz
{
    public class FizzRule : IRule
    {
        public string Run(double number)
        {
            return (number % 3) == 0 ? "Fizz" : string.Empty;
        }
    }
}
