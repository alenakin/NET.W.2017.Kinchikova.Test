using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Solution;

namespace Task2.Tests
{
    class Program
    {
        public static void Main()
        {
            GenerateRandomFile(new RandomBytesFileGenerator(), 2, 24);
            GenerateRandomFile(new RandomCharsFileGenerator(), 1, 20);
        }

        private static void GenerateRandomFile(FileGenerator generator, int fileCount, int contentLength)
        {
            generator.GenerateFiles(fileCount, contentLength);
        }
    }
}
