using AddressBook.AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBook
{
    public  class AddressBookMain
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to address book");

            List<Contact> contacts = new List<Contact>();
            Contact obj = new Contact()
            {
                firstName = "Prathmesh",
                lastName = "Biradar",
                address = "Karve nagar",
                city = "Pune",
                state = "Maharashtra",
                zip = "422012",
                phonenumber = "7843038332",
                email = "psbiradar948@gmail.com"
            };
            contacts.Add(obj);
            foreach (var i in contacts)
            {
                Console.WriteLine($"name:{i.firstName} {i.lastName}, Address: {i.address}, City: {i.city}, State: {i.state}, Zip: {i.zip}, PhoneNumber: {i.phonenumber}, Email: {i.email} ");
            }

        }
    }
}
