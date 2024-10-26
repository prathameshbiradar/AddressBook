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
        public Dictionary<string, List<Contact>> contactsByCity;
        public Dictionary<string, List<Contact>> contactsByState;
        public AddressBook()
        {
            contacts = new List<Contact>();
            contactsByCity = new Dictionary<string, List<Contact>>(StringComparer.OrdinalIgnoreCase);
            contactsByState = new Dictionary<string, List<Contact>>(StringComparer.OrdinalIgnoreCase);
        }

        public void addContact(Contact contact)
        {
            if (!contacts.Contains(contact))
            {
                contacts.Add(contact);
                AddToCityDictionary(contact);
                AddToStateDictionary(contact);
                Console.WriteLine("Contact added Successfully");
            }
            else
            {
                    Console.WriteLine("Duplicate contact found! Contact not added.");
            }
            
        }
        private void AddToCityDictionary(Contact contact)
        {
            if (!contactsByCity.ContainsKey(contact.city))
            {
                contactsByCity[contact.city] = new List<Contact>();
            }
            contactsByCity[contact.city].Add(contact);
        }

        private void AddToStateDictionary(Contact contact)
        {
            if (!contactsByState.ContainsKey(contact.state))
            {
                contactsByState[contact.state] = new List<Contact>();
            }
            contactsByState[contact.state].Add(contact);
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
        public List<Contact> GetContactsByCity(string city)
        {
            if (contactsByCity.TryGetValue(city, out List<Contact> contactsInCity))
            {
                return contactsInCity;
            }
            return new List<Contact>(); 
        }

        public List<Contact> GetContactsByState(string state)
        {
            if (contactsByState.TryGetValue(state, out List<Contact> contactsInState))
            {
                return contactsInState;
            }
            return new List<Contact>(); 
        }
    }
}
