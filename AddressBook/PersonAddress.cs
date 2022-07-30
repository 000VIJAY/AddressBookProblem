using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class PersonAddress
    {
        public List<Contact> persons = new List<Contact>();

        public void Book(Contact con)
        {

            persons.Add(new Contact() { FirstName = "Vijay", LastName = "kumar", City = "Patna", State = "Bihar", Zip = 8000001, PhoneNumber = 87654321287, Email = "vijya87348@gmail.com", });
            persons.Add(new Contact() { FirstName = "Nitish", LastName = "kumar", City = "Patna", State = "Bihar", Zip = 800005, PhoneNumber = 654321287, Email = "vijya87348@gmail.com", });
            persons.Add(new Contact() { FirstName = "Rahul ", LastName = "Yadav", City = "Delhi", State = "New Delhi", Zip = 534342, PhoneNumber = 43523254234, Email = "rahul@gmail.com" });
            persons.Add(new Contact() { FirstName = "Rohal ", LastName = "Goyal", City = "Delhi", State = "New Delhi", Zip = 534342, PhoneNumber = 76523254234, Email = "rohan@gmail.com" });
            foreach (var Contact in persons)
            {
                Console.WriteLine("Your name is :{0} ", Contact.FirstName + " " + Contact.LastName);
                Console.WriteLine("Your City: {0}", Contact.City);
                Console.WriteLine("Your State: {0}", Contact.State);
                Console.WriteLine("Your Zip:{0}", Contact.Zip);
                Console.WriteLine("Your PhoneNumber: {0}", Contact.PhoneNumber);
                Console.WriteLine("Email: {0}", Contact.Email);
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}
