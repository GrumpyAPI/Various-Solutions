using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());

            int projectTime = projectCount * 3;

            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", architectName, projectTime, projectCount);

        }
    }
}
