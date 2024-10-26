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
            AddressBook addressbook = new AddressBook();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Print Contact");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose an option: ");
                String choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Contact newContact = new Contact();
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
                        break;

                    case "2":
                        Console.WriteLine("Enter the first name of contact to edit:");
                        String firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last name of contact to edit");
                        String lastName = Console.ReadLine();
                        addressbook.editContact(firstName, lastName);
                        break;

                    case "3":
                        addressbook.printContact();
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting the application..");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.Please Try Again");
                        break;
                }
            }


           
            

            

        }
    }
}
