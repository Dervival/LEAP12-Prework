using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

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
            //AppendViaStreamWriter();
            XmlPractice();
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

        /// <summary>
        /// Function for practicing XML deserialization from a file, modification of properties, and reserialization and saving to another file.
        /// </summary>
        static void XmlPractice()
        {
            string filepath = @"C:\Users\oobitydoo\Documents\fileioxml.txt";
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filepath);

            //should grab all the user info from the xml, needs to be parsed
            XmlNodeList usersXml = xmlDocument.SelectNodes("//User");

            User[] users = new User[usersXml.Count];

            //can't seem to directly iterate over XmlNodeList to grab elements, but can foreach
            int userIndex = 0;
            foreach(XmlElement element in usersXml)
            {
                //start with the basic properties of a user
                User user = new User();
                if (element.HasAttribute("FirstName"))
                {
                    user.FirstName = element.GetAttribute("FirstName");
                }
                if (element.HasAttribute("LastName"))
                {
                    user.LastName = element.GetAttribute("LastName");
                }
                if (element.HasAttribute("Profession"))
                {
                    user.Occupation = element.GetAttribute("Profession");
                }

                //parse the address info then assign it to a user
                Address address = new Address();
                XmlElement addressElement = (XmlElement)element.FirstChild;
                address.Street = addressElement.GetAttribute("Street");
                address.City = addressElement.GetAttribute("City");
                address.State = addressElement.GetAttribute("State");
                address.Zip = addressElement.GetAttribute("Zip");
                user.HomeAddress = address;

                //add user to array then continue
                users[userIndex] = user;
                userIndex++;
            }

            //Now that we've got xml, update something
            users[1].HomeAddress.City = "Gotham City"; //updating Batman to explicitly live in Gotham

            string savePath = @"C:\Users\oobitydoo\Documents\fileioxmlout.txt";

            //Now to serialize the array of users into xml and format it into a string so that it can be saved
            //Serializing help taken from the serialization documentation - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/how-to-write-object-data-to-an-xml-file
            XmlSerializer xmlWriter = new XmlSerializer(typeof(User[]));
            FileStream file = File.Create(savePath);
            xmlWriter.Serialize(file, users);
            file.Close();
        }
    }
    /// <summary>
    /// Struct for the user in the xml document provided - has first and last name, occupation/profession, and home address info
    /// </summary>
    public struct User
    {
        public string FirstName;
        public string LastName;
        public string Occupation;
        public Address HomeAddress;
    }
    /// <summary>
    /// Struct for the address in the xml document provided - has street, city, state, and zip code information
    /// </summary>
    public struct Address
    {
        public string Street;
        public string City;
        public string State;
        public string Zip;
    }
}
