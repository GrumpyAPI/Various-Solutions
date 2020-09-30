using System;
using System.IO;

namespace Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = "../../../../Resources/06. Folder Size/TestFolder";
            string outputFile = "../../../../Resources/06. Folder Size/Output.txt";

            string[] files = Directory.GetFiles(sourceFile);

            double sum = 0;

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = double.Parse($"{sum / 1024 / 1024:F2}");

            File.WriteAllText(outputFile, sum.ToString());
        }
    }
}
