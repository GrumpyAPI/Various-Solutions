using System;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            Action<string[]> lambdaAction = arr => Console.WriteLine(string.Join(Environment.NewLine, arr));

            lambdaAction(input);
        }
    }
}
