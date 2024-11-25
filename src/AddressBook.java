import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class AddressBook {
    List<Contact> contacts;
    Scanner sc = new Scanner(System.in);

    public AddressBook()
    {
        contacts= new ArrayList<>();
    }


    public void addContact(Contact contact) {
        contacts.add(contact);
        System.out.println("Contact added successfully!");
    }

    public void displayAllContacts()
    {
        if (contacts.isEmpty())
        {
            System.out.println("No contacts available.");
        }
        else
        {
            System.out.println("\n--- All Contacts ---");
            for (Contact contact : contacts) {
                System.out.println(contact);
                System.out.println("-------------------------");
            }
        }
    }
    public Contact findContactByName(String name)
    {
        for (Contact contact : contacts)
        {
            if (contact.getFirstName().equalsIgnoreCase(name) || contact.getLastName().equalsIgnoreCase(name))
            {
                return contact;
            }
        }
        return null;
    }
    public void editContact(Contact contact) {
        if (contact != null)
        {
            System.out.println("\nEditing Contact: " + contact.getFirstName() + " " + contact.getLastName());


            System.out.println("Enter new First Name (current: " + contact.getFirstName() + "): ");
            String newFirstName = sc.nextLine();
            if (!newFirstName.isEmpty())
            {
                contact.setFirstName(newFirstName);
            }

            System.out.println("Enter new Last Name (current: " + contact.getLastName() + "): ");
            String newLastName = sc.nextLine();
            if (!newLastName.isEmpty())
            {
                contact.setLastName(newLastName);
            }

            System.out.println("Enter new Address (current: " + contact.getAddress() + "): ");
            String newAddress = sc.nextLine();
            if (!newAddress.isEmpty())
            {
                contact.setAddress(newAddress);
            }

            System.out.println("Enter new City (current: " + contact.getCity() + "): ");
            String newCity = sc.nextLine();
            if (!newCity.isEmpty())
            {
                contact.setCity(newCity);
            }

            System.out.println("Enter new State (current: " + contact.getState() + "): ");
            String newState = sc.nextLine();
            if (!newState.isEmpty())
            {
                contact.setState(newState);
            }

            System.out.println("Enter new Zip (current: " + contact.getPinCode() + "): ");
            String newZip = sc.nextLine();
            if (!newZip.isEmpty())
            {
                contact.setPinCode(newZip);
            }

            System.out.println("Enter new Phone Number (current: " + contact.getPhoneNumber() + "): ");
            String newPhone = sc.nextLine();
            if (!newPhone.isEmpty())
            {
                contact.setPhoneNumber(newPhone);
            }

            System.out.println("Enter new Email (current: " + contact.getEmail() + "): ");
            String newEmail = sc.nextLine();
            if (!newEmail.isEmpty())
            {
                contact.setEmail(newEmail);
            }

            System.out.println("Contact updated successfully!");
        }
        else
        {
            System.out.println("Contact not found.");
        }
    }

}
