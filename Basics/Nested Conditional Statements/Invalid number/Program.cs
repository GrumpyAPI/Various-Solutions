﻿using System;

namespace Invalid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 100 || number > 200)
            {
                if (number != 0)
                {
                    Console.WriteLine("invalid");
                }
            }

        }
    }
}