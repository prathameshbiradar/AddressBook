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
                Console.WriteLine("5. view contact by city");
                Console.WriteLine("6. view contact by state");
                Console.WriteLine("7. Go Back");
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
                        Console.WriteLine("Enter city to view contacts: ");
                        string city = Console.ReadLine();
                        var contactInCity = selectedBook.GetContactsByCity(city);
                        int cityCount = selectedBook.GetContactCountByCity(city);
                        Console.WriteLine($"Total contacts in city {city}: {cityCount}");
                        if (contactInCity.Any())
                        {
                            Console.WriteLine("Contacts in city " + city + ":");
                            foreach (var contact in contactInCity)
                            {
                                Console.WriteLine(contact);
                            }

                        }
                        else 
                        {
                            Console.WriteLine("No contacts found in city " + city);
                        }
                        break;

                    case "6":
                        Console.WriteLine("Enter state to view contacts: ");
                        string state = Console.ReadLine();
                        var contactsInState = selectedBook.GetContactsByState(state);
                        int stateCount = selectedBook.GetContactCountByState(state);
                        Console.WriteLine($"Total contacts in state {state}: {stateCount}");
                        if (contactsInState.Any())
                        {
                            Console.WriteLine("Contacts in state " + state + ":");
                            foreach (var contact in contactsInState)
                            {
                                Console.WriteLine(contact);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contacts found in state " + state);
                        }
                        break;


                    case "7":
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

