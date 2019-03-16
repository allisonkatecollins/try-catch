using System;
using System.Collections.Generic;

namespace try_catch
{
  public class AddressBook
  {
    //Use a Dictionary in the AddressBook class to store Contacts.
    //The key should be the contact's email address.
    public Dictionary<string, Contact> addressBook {get; set;} = new Dictionary<string, Contact>();

    public void AddContact(Contact contact)
    {
      addressBook.Add(contact.Email, contact);
    }

    public Contact GetByEmail(string email)
    //without try/catch, this error occurs:
    //'AddressBook.GetByEmail(string)' must declare a body because it is not marked abstract, extern, or partial
    { 
      try 
      {
      Contact contactReturn = addressBook[email];
      return contactReturn;
      }
      catch(KeyNotFoundException)
      {
        return null;
      }
    } 

  }

}