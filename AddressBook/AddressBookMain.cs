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
            CrudOperation crud = new CrudOperation();
            AddressBookManager addressBookManager = new AddressBookManager();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Display Address Book");
                Console.WriteLine("4. Delete Address Book");
                Console.WriteLine("4. Search Contacts");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option: ");
                String choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter name of the new Address Book: ");
                        string bookname = Console.ReadLine();
                        addressBookManager.addAddressBook(bookname);
                        break;
                    case "2":
                        Console.WriteLine("Enter the name of the Address Book to select: ");
                        string selectbookname = Console.ReadLine();
                        AddressBook selectedBook = addressBookManager.getAddressBook(selectbookname);
                        if (selectedBook != null)
                        {
                           crud.ManageAddressBook(selectedBook);
                        }
                        break;
                    case "3":
                        addressBookManager.displayAddressBooks();
                        break;

                    case "4":
                        Console.WriteLine("Enter the name of the Address Book to delete:");
                        String deleteBookName = Console.ReadLine();
                        addressBookManager.deleteAddressBook(deleteBookName);
                        break;

                    case "5":
                        Console.WriteLine("Enter City to search: ");
                        String searchCity = Console.ReadLine();
                        Console.WriteLine("Enter City to search: ");
                        String searchState = Console.ReadLine();
                        var searchResult = addressBookManager.searchContact(string.IsNullOrEmpty(searchCity) ? null : searchCity,
                                            string.IsNullOrEmpty(searchState) ? null : searchState);
                        if (searchResult.Any())
                        {
                            Console.WriteLine("Search Results: ");
                            foreach (var contact in searchResult)
                            {
                                Console.WriteLine($"Name: {contact.firstName} {contact.lastName}, City: {contact.city}, State: {contact.state}");
                            }

                        }
                        break;

                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Option.Please try again.");
                        break;
                }
            }
        }

    }
}
    
