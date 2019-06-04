using System;

namespace address_book
{
    public class Contact
    {
        //Set properties for the employee's first name, last name, address, and email
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        //Get employee's full name
        public string FullName => $"{FirstName} {LastName}";
    }
}