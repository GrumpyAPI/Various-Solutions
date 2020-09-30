using System;
using System.IO;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstReader = new StreamReader(@"..\..\..\..\Resources\04. Merge Files\FileOne.txt");
            var secondReader = new StreamReader(@"..\..\..\..\Resources\04. Merge Files\FileTwo.txt");
            var writer = new StreamWriter("../../../../Resources/04. Merge Files/Output.txt");

            using (firstReader)
            {
                using (secondReader)
                {
                    using (writer)
                    {
                        var firstLine = firstReader.ReadLine();
                        var secondLine = secondReader.ReadLine();

                        while (firstLine != null)
                        {
                            writer.WriteLine(firstLine);
                            writer.WriteLine(secondLine);

                            firstLine = firstReader.ReadLine();
                            secondLine = secondReader.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
