using System;
using System.Collections.Generic;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new HashSet<int>();
            int n = int.Parse(Console.ReadLine());

            int isEven = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (nums.Contains(num))
                {
                    isEven = num;
                }

                nums.Add(num);
            }

            Console.WriteLine(isEven);
        }
    }
}
