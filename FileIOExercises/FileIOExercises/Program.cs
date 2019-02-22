using System;
using System.IO;

namespace FileIOExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadViaFileClass();
            //ReadViaStreamReader();
            //WriteViaFileClass();
            //AppendViaFileClass();
            AppendViaStreamWriter();
        }

        /// <summary>
        /// Reads in the file in the hardcoded path using the System.IO File class and prints it to the console.
        /// </summary>
        static void ReadViaFileClass()
        {
            //string path = @"C:\Users\oobitydoo\LEAP\LEAP12 - Prework\fileioread.txt"; //original path - I think it disliked spaces in the path
            string path = @"C:\Users\oobitydoo\Documents\fileioread.txt";
            string pathContents = File.ReadAllText(path);
            Console.WriteLine(pathContents);
        }

        /// <summary>
        /// Reads in the file in the hardcoded path using the System.IO StreamWriter class and prints it to the console.
        /// </summary>
        static void ReadViaStreamReader()
        {
            string path = @"C:\Users\oobitydoo\Documents\fileioread.txt";
            using (StreamReader streamReader = new StreamReader(path))
            {
                while (!streamReader.EndOfStream)
                {
                    var readLine = streamReader.ReadLine();
                    Console.WriteLine(readLine);
                }
                streamReader.Close();
            }
        }

        /// <summary>
        /// Directly writes the message "Hello world!" to the hardcoded path, overwriting anything previously stored there.
        /// </summary>
        static void WriteViaFileClass()
        {
            string path = @"C:\Users\oobitydoo\Documents\fileiowrite.txt";
            string message = "Hello world!\n";
            File.WriteAllText(path, message);
        }

        /// <summary>
        /// Appends the hardcoded message to the file at the path defined using the file class.
        /// </summary>
        static void AppendViaFileClass()
        {
            string path = @"C:\Users\oobitydoo\Documents\fileiowrite.txt";
            string message = "This is an appended line of text using the File class.\n";
            File.AppendAllText(path, message);
        }

        /// <summary>
        /// Appends the hardcoded message to the file at the path defined using a StreamWriter.
        /// </summary>
        static void AppendViaStreamWriter()
        {
            string path = @"C:\Users\oobitydoo\Documents\fileiowrite.txt";
            string message = "This is an appended line of text using the StreamWriter class.\n";
            //remember to use a boolean to append
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}
