using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something
{
    internal class ContactBook
    {
        List<Contacts> contacts { get; set; }
        public ContactBook()
        {
            contacts = new List<Contacts>();
        }

        // Add a contact inside the List 
        public void addContact(Contacts contact)
        {
            contacts.Add(contact);
            Console.WriteLine("New contacts has been added!");

        }

        // this methods return a Contact value 
        public Contacts searchPerson(string name)
        {
            foreach(Contacts contact in contacts)
            {
                // Note: You can add , StringComparison.OrdinalIgnoreCase to add search for a person 
                // even if it is caps or not it will show the result

                if (contact.Name.Equals(name))
                {
                    return contact;
                }
            }
            // if the name does not match then return null 
            return null;
        }

        public void removeContacts(string email)
        {
            Contacts contactToRemove = null;

            foreach(Contacts contact in contacts)
            {
                if (contact.Email.Equals(email))
                    {
                    contactToRemove = contact;
                    break; // Exit the loop when the contact to remove is assigned
                }
            }

            // continue this after exiting the loop

            if(contactToRemove != null)
            {
                // use the .Remove method to remove a contact
                contacts.Remove(contactToRemove);
                Console.WriteLine("Contact has been removed!");
            }
            else
            {
                Console.WriteLine("Contact not found...");
            }
        }
    }
}
