using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookIO
{
      class AddressBook
    {
        List<Person> adressBookList;//create list
        public AddressBook()//default constructor
        {
            this.adressBookList = new List<Person>();
        }
        public void AddContact(string firstName, string lastName, string address, string city, string state, long phoneNumber, string email, int zip)
        {
            bool flag = this.adressBookList.Any(item => item.firstName == firstName && item.lastName == lastName);
            if (!flag)
            {
                Person person = new Person(firstName, lastName, city, state, email, phoneNumber, zip);//create new object of person class
                adressBookList.Add(person);//adding person details in addressbookList 
                Console.WriteLine("Contact added Successfully");
                Console.WriteLine();
                Console.WriteLine("New contact");
            }
            else
            {
                Console.WriteLine("{0}{1} this contact already exist in Address Book :", firstName, lastName);
            }
        }
        public void displayPerson()
        {
            Console.WriteLine("\nEntered Person Details is:");
            foreach (var person in adressBookList)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}, Zip:{6}", person.firstName, person.lastName, person.city, person.state, person.email, person.phoneNumber, person.zip);
            }
        }

        public void displayPersonInOrder()
        {
            Console.WriteLine("\nEntered Person Details is in Order :");
            foreach (var person in adressBookList.OrderBy(Key => Key.firstName))//orderBy sorts the vlues of collection in ascending or decending order
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}, Zip:{6}", person.firstName, person.lastName, person.city, person.state, person.email, person.phoneNumber, person.zip);
            }
        }
    }
}
