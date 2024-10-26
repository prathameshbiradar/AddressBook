using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBook
{
    public class AddressBook
    {
        public List<Contact> contacts = new List<Contact>();

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
    }
}
