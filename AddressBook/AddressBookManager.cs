using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBook
{
    public class AddressBookManager
    {
        Dictionary<String, AddressBook> addressBooks;
        public AddressBookManager()
        {
            addressBooks = new Dictionary<String, AddressBook>();
        }

        public void addAddressBook(String name)
        {
            if (!addressBooks.ContainsKey(name))
            {
                addressBooks[name] = new AddressBook();
                Console.WriteLine($"Address Book {name} added.");
            }
            else
            {
                Console.WriteLine("Address book with this name already exists.");
            }     
        }
        public AddressBook getAddressBook(String name)
        {
            if (addressBooks.TryGetValue(name, out AddressBook addressBook))
            {
                return addressBook;
            }
            Console.WriteLine("Address Book not found");
            return null;
        }
        public void deleteAddressBook(String name)
        {
            if (addressBooks.Remove(name))
            {
                Console.WriteLine($"Address Book '{name}' deleted successfully");
            }
            else 
            {
                Console.WriteLine($"Address book '{name}' not found");
            }
        }
        public void displayAddressBooks()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No Address Book Available");
                return;
            }
            Console.WriteLine("Available Address Books:");
            foreach (var book in addressBooks)
            {
                Console.WriteLine($"{book.Key}");
            }
        }

    }
}
