using AddressBook.AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBook
{
    public  class AddressBookMain
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to address book");

            Contact newContact = new Contact();
            AddressBook addressbook = new AddressBook();

            Console.WriteLine("Enter First Name:");
            newContact.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            newContact.lastName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            newContact.address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            newContact.city = Console.ReadLine();
            Console.WriteLine("Enter State: ");
            newContact.state = Console.ReadLine();
            Console.WriteLine("Enter Zip Code :");
            newContact.zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            newContact.phonenumber = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            newContact.email = Console.ReadLine();

            addressbook.addContact(newContact);
            addressbook.printContact();

        }
    }
}
