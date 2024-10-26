using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBook
{
    public class AddressBook
    {
        public List<Contact> contacts;
        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void addContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Contact added Successfully");
        }
        public void printContact()
        {
            foreach (var i in contacts)
            {
                Console.WriteLine($"name:{i.firstName} {i.lastName}, Address: {i.address}," +
                $" City: {i.city}, State: {i.state}, Zip: {i.zip}, PhoneNumber: {i.phonenumber}, Email: {i.email} ");
            }
        }
        public void editContact(String firstName, String lastName)
        {
            var contact = contacts.FirstOrDefault(c => c.firstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                         c.lastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                Console.WriteLine("Enter new Address: ");
                String newAddress = Console.ReadLine();
                contact.address = newAddress;

                Console.WriteLine("Enter new City: ");
                String newCity = Console.ReadLine();
                contact.city = newCity;

                Console.WriteLine("Enter new State: ");
                String newState = Console.ReadLine();
                contact.state = newState;

                Console.WriteLine("Enter new Zip Code ");
                String newZip = Console.ReadLine();
                contact.zip = newZip;

                Console.WriteLine("Enter new Phonenumber: ");
                String newPhone = Console.ReadLine();
                contact.phonenumber = newPhone;

                Console.WriteLine("Enter new Email: ");
                String newEmail = Console.ReadLine();
                contact.email = newEmail;
            }
            else 
            {
                Console.WriteLine("Contact not found");
            }
        }
        public void deleteContact(string firstName, string lastName)
        {
            if (contacts == null)
            {
                Console.WriteLine("Contact List is Empty");
            }
            var contact = contacts.FirstOrDefault(c => c.firstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                         c.lastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }
}
