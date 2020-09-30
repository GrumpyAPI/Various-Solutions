using System;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Select(x => $"Sir {x}")
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
