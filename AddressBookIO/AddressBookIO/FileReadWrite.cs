using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookIO
{
     class FileReadWrite
    {
        static String FilePath = @"C:\Users\Radha\source\repos\AddressBookSystem\AddressBookSystem\Address.txt";
        static string FilePathCsv = @"C:\Users\Radha\source\repos\AddressBookSystem\AddressBookSystem\Csvdata.csv";
        static String filePathJson = @"C:\Users\Radha\source\repos\AddressBookSystem\AddressBookSystem\jsonfile.json";
        public static void WriteTxtFile(List<Person> persons)
        {
            if (File.Exists(FilePath))
            {
                using (StreamWriter streamWriter = File.AppendText(FilePath))
                {
                    foreach (Person person in persons)
                    {
                        streamWriter.WriteLine(" \nPersons detail ");
                        streamWriter.WriteLine("FirstName: " + person.firstName);
                        streamWriter.WriteLine("LastName: " + person.lastName);
                        streamWriter.WriteLine("City    : " + person.city);
                        streamWriter.WriteLine("Email   : " + person.email);
                        streamWriter.WriteLine("State   : " + person.state);
                        streamWriter.WriteLine("PhoneNum: " + person.phoneNumber);

                    }
                    streamWriter.Close();
                }
                Console.WriteLine("Writting Persons detail in to the Text the file");
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }


        public static void ReadContactsInCSVFile()
        {
            if (File.Exists(FilePathCsv))
            {
                string[] csv = File.ReadAllLines(FilePathCsv);
                foreach (string csValues in csv)
                {
                    string[] column = csValues.Split(',');
                    foreach (string CSValues in column)
                    {
                        Console.WriteLine(CSValues);
                    }
                }
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }
        public static void WriteContactsInJSONFile(List<Person> contacts)
        {
            if (File.Exists(filePathJson))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter streamWriter = new StreamWriter(filePathJson))
                using (JsonWriter writer = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(writer, contacts);
                }
                Console.WriteLine("Writting Contacts to the JSON file");
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }
        public static void ReadContactsFromJSONFile()
        {
            if (File.Exists(filePathJson))
            {
                IList<Person> contactsRead = JsonConvert.DeserializeObject<IList<Person>>(File.ReadAllText(filePathJson));
                foreach (Person contact in contactsRead)
                {
                    Console.Write(contact.ToString());
                }
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }
    }
}
