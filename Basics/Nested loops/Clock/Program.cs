using System;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)        //Program is enhanced from the requirement.
            {
                int h;
                int m;
                int s;
                for (h = 0; h <= 23; h++)
                {
                    for (m = 0; m <= 59; m++)
                    {
                        for (s = 0; s <= 59; s++)
                        {
                            Console.WriteLine($"{h:D2}:{m:D2}:{s:D2}");
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(0, 0);
                        }
                    }
                }
                if (h > 23)
                {
                    h = 0;
                    m = 0;
                    s = 0;
                }
            }
        }
    }
}
