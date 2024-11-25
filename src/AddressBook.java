import java.util.ArrayList;
import java.util.List;

public class AddressBook {
    List<Contact> contacts;

    public AddressBook()
    {
        contacts= new ArrayList<>();
    }


    public void addContact(Contact contact) {
        contacts.add(contact);
        System.out.println("Contact added successfully!");
    }

    public void displayAllContacts() {
        if (contacts.isEmpty()) {
            System.out.println("No contacts available.");
        } else {
            System.out.println("\n--- All Contacts ---");
            for (Contact contact : contacts) {
                System.out.println(contact);
                System.out.println("-------------------------");
            }
        }
    }
}
