using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int rows = 1; rows <= number; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    counter++;
                    Console.Write($"{counter} ");

                    if (counter == number)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


// The way it is done in the softuni example.
//using System;

//namespace Number_Pyramid
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int number = int.Parse(Console.ReadLine());

//            int current = 1;
//            bool isBigger = false;

//            for (int rows = 1; rows <= number; rows++)
//            {
//                for (int cols = 1; cols <= rows; cols++)
//                {
//                    if (current > number)
//                    {
//                        isBigger = true;
//                        break;
//                    }
//                    Console.Write(current + " ");
//                    current++;
//                }
//                if (isBigger)
//                {
//                    break;
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}



// Displaying the numbers from 1 to whichever number you enter, each time with 1 more.
//using System;

//namespace Number_Pyramid
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int number = int.Parse(Console.ReadLine());

//            for (int rows = 1; rows <= number; rows++)
//            {
//                for (int cols = 1; cols <= rows; cols++)
//                {
//                    Console.Write(cols);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

// Same thing as above but in reverse and each time removes the first digit.
//using System;

//namespace Number_Pyramid
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int number = int.Parse(Console.ReadLine());

//            for (int rows = 1; rows <= number; rows++)
//            {
//                for (int cols = rows; cols <= number; cols++)
//                {
//                    Console.Write(cols);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}