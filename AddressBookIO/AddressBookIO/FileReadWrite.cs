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
    }
}
