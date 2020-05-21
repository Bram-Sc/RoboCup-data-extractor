using System;

namespace RoboCup_data_extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            DataExtractor dataExtractor;
            string path;

            Console.WriteLine("Enter the path of the .cvs file.");
            path = Console.ReadLine();
            Console.WriteLine("Extracting...");
            dataExtractor = new DataExtractor();
            dataExtractor.Extract(path);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
