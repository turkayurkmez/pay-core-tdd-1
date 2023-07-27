namespace FizzBuzz.Game
{
    public class GameBoard
    {
        public string GetWordOrNumber(int value)
        {
            if (value % 15 == 0)
            {
                return ResultConstant.FizzBuzz;
            }
            else if (value % 3 == 0)
            {
                return ResultConstant.Fizz;
            }
            else if (value % 5 == 0)
            {
                return ResultConstant.Buzz;
            }

            return value.ToString();
        }
    }

    public class ResultConstant
    {
        public const string Fizz = "Fizz";
        public const string Buzz = "Buzz";
        public const string FizzBuzz = "FizzBuzz";


    }
}
