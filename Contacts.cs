using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something
{
    internal class Contacts
    {
        // GETTERS  AND SETTERS
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public long phoneNumber { get; set; }


        // Constructors
        public Contacts(string Name, string Email, int Age, long phoneNumber)
        {

            this.Name = Name;
            this.Email = Email;
            this.Age = Age;
            this.phoneNumber = phoneNumber;


        }
    }
}
