namespace Something
{
    internal class Launcher
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("Current Directory: " + currentDirectory);

            ContactBook contactBook = new ContactBook();
            bool exit = false;

            // while the exit is true then continue running it
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("1. Add a contact");
                Console.WriteLine("2. Search for a contact");
                Console.WriteLine("3. Remove a contact");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add a new Contact");

                        Console.WriteLine();
                        // promt
                        Console.Write("Enter your name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter your email: ");
                        string email = Console.ReadLine();

                        Console.Write("Enter your age: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter your Phone Number: ");
                        string strNum = Console.ReadLine();
                        Console.WriteLine();

                        if (long.TryParse(strNum, out long phoneNum))
                        {
                            Contacts newContact = new Contacts(name, email, age, phoneNum);
                            contactBook.addContact(newContact);
                        }
                        else
                        {
                            Console.WriteLine("Invalid phone number format.");
                        }
                        break;

                    case 2:
                        // promt 
                        Console.WriteLine("Search contacts");
                        Console.WriteLine();
                        Console.Write("Search for name: ");
                        string searchName = Console.ReadLine();

                        Contacts searchContact = contactBook.searchPerson(searchName);
                        if (searchContact != null) // If the  searchContact is  null then that means
                                                   // there are no name that correspond to that user that means it's null
                        {
                            // Display the Users information
                            Console.WriteLine("====================================");

                            Console.WriteLine("Name: " + searchContact.Name);
                            Console.WriteLine("Email: " + searchContact.Email);
                            Console.WriteLine("Age: " + searchContact.Age);
                            Console.WriteLine("Phone Number: " + searchContact.phoneNumber);
                            Console.WriteLine("====================================");

                        }
                        // if the searchPerson method returns null print this
                        else
                        {
                            Console.WriteLine("Contact not found.");
                        }
                        break;

                    case 3:
                        // Implement update logic here
                        Console.Write("Enter a email to remove: ");
                        string emailDelete = Console.ReadLine();
                        contactBook.removeContacts(emailDelete);

                        break;

                    // exit the program
                    case 4:
                        // now the exit is true now it will exit the console
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again!");
                        break;
                }
            }
        }
    }
}
