using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBook
{
    public class CrudOperation
    {
        public void ManageAddressBook(AddressBook selectedBook)
        {
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Print Contact");
                Console.WriteLine("5. Go Back");
                Console.WriteLine("Choose an option: ");
                String choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        bool addContacts = true;
                        while (addContacts)
                        {
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
                            selectedBook.addContact(newContact);

                            Console.WriteLine("Do you want to add another contact ? (Yes/No) ");
                            addContacts = Console.ReadLine().Trim().ToLower() == "yes";

                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter the first name of contact to edit:");
                        String firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last name of contact to edit");
                        String lastName = Console.ReadLine();
                        selectedBook.editContact(firstName, lastName);
                        break;

                    case "3":
                        Console.WriteLine("Enter the first name of contact to edit:");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last name of contact to edit");
                        lastName = Console.ReadLine();
                        selectedBook.deleteContact(firstName, lastName);
                        break;

                    case "4":
                        selectedBook.printContact();
                        break;

                    case "5":
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.Please Try Again");
                        break;
                }
            }
        }
    }
}

