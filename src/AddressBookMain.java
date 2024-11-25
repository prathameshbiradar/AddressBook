import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class AddressBookMain {
    public static void main(String[] args) {
        AddressBook addressBook = new AddressBook();
        Scanner sc = new Scanner(System.in);
        boolean exit=true;
        while(exit)
        {
            System.out.println("Address Book Menu:");
            System.out.println("1. Add New Contact");
            System.out.println("2. Display Contacts");
            System.out.println("3. Edit Contact");
            System.out.println("4. Exit");
            System.out.print("Enter your choice: ");
            int choice = sc.nextInt();
            switch(choice)
            {
                case 1:
                    System.out.println("\nEnter First Name: ");
                    String firstName = sc.nextLine();
                    System.out.println("Enter Last Name: ");
                    String lastName = sc.nextLine();
                    System.out.println("Enter Address: ");
                    String address = sc.nextLine();
                    System.out.println("Enter City: ");
                    String city = sc.nextLine();
                    System.out.println("Enter State: ");
                    String state = sc.nextLine();
                    System.out.println("Enter Zip: ");
                    String zip = sc.nextLine();
                    System.out.println("Enter Phone Number: ");
                    String phoneNumber = sc.nextLine();
                    System.out.println("Enter Email: ");
                    String email = sc.nextLine();
                    Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);

                    // Add the contact to the address book
                    addressBook.addContact(newContact);
                    break;
                case 2:
                    addressBook.displayAllContacts();
                    break;
                case 3:
                    System.out.println("\nEnter the First or Last Name of the contact to edit: ");
                    String nameToEdit = sc.nextLine();


                    Contact contactToEdit = addressBook.findContactByName(nameToEdit);


                    addressBook.editContact(contactToEdit);
                    break;
                case 4:
                    // Exit the program
                    System.out.println("Exiting Address Book...");
                    sc.close();
                    return;

                default:
                    System.out.println("Invalid choice, please try again.");

            }

        }
    }
}