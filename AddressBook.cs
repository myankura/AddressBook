using System;
using System.Collections.Generic;

namespace address_book
{
    public class AddressBook
    {
        //Create a dictionary for storing contacts
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>()
        {
        };

        //Create a method for adding new contacts
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact.Email, contact);
        }

        //Get contacts by email
        public Contact GetByEmail(string email)
        {
            //Use square bracket to access the Contacts dictionary and return them by their email address.
            return Contacts[email];
        }
    }
};