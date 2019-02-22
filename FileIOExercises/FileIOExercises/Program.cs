using System;
using System.IO;

namespace FileIOExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadViaFileClass();
            ReadViaStreamReader();
        }

        static void ReadViaFileClass()
        {
            //string path = @"C:\Users\oobitydoo\LEAP\LEAP12 - Prework\fileioread.txt"; //original path - I think it disliked spaces in the path
            string path = @"C:\Users\oobitydoo\Documents\fileioread.txt";
            string pathContents = File.ReadAllText(path);
            Console.WriteLine(pathContents);
        }

        static void ReadViaStreamReader()
        {
            string path = @"C:\Users\oobitydoo\Documents\fileioread.txt";
            StreamReader streamReader = new StreamReader(path);
            while (!streamReader.EndOfStream)
            {
                var readLine = streamReader.ReadLine();
                Console.WriteLine(readLine);
            }
            streamReader.Close();
        }
    }
}
