﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class PersonAddress
    {
        public List<Contact> persons = new List<Contact>();

        public void Book()
        {

            persons.Add(new Contact() { FirstName = "Vijay", LastName = "kumar", City = "Patna", State = "Bihar", Zip = 8000001, PhoneNumber = 87654321287, Email = "vijya87348@gmail.com", });
            persons.Add(new Contact() { FirstName = "Nitish", LastName = "kumar", City = "Patna", State = "Bihar", Zip = 800005, PhoneNumber = 654321287, Email = "vijya87348@gmail.com", });
            persons.Add(new Contact() { FirstName = "Rahul ", LastName = "Yadav", City = "Delhi", State = "New Delhi", Zip = 534342, PhoneNumber = 43523254234, Email = "rahul@gmail.com" });
            persons.Add(new Contact() { FirstName = "Rohal ", LastName = "Goyal", City = "Delhi", State = "New Delhi", Zip = 534342, PhoneNumber = 76523254234, Email = "rohan@gmail.com" });
            Display();
        }
        public void Addcontact()
        {
            Console.WriteLine("How many contacts wants to add , any case do not willing to add new contact press 0");
            int newCon = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < newCon; i++)
            {
                Console.WriteLine("Enter Firstname");
                string? FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                string? LastName = Console.ReadLine();
                Console.WriteLine("Enter City");
                string? City = Console.ReadLine();
                Console.WriteLine("Enter State");
                string? State = Console.ReadLine();
                Console.WriteLine("Enter zip Number : only digit is valid");
                int Zip = (int)Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter Phone Number");
                long PhoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter your email");
                string? Email = Console.ReadLine();
                persons.Add(new Contact()
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    City = City,
                    State = State,
                    Zip = Zip,
                    PhoneNumber = PhoneNumber,
                    Email = Email,
                });
            }
        }
        public void EditContact()
        {
            //only edit the added contact
            Console.WriteLine("To edit contact list enter First Name");
            string name = Console.ReadLine().ToLower();

            foreach (var Contacts in persons)
            {
                if (persons.Contains(Contacts))
                {
                    if (Contacts.FirstName.Equals(name))
                    {
                        Console.WriteLine("enter the information wants to edit");
                        Console.WriteLine("For edit First Name enter - 0");
                        Console.WriteLine("For edit Last Name enter - 1");
                        Console.WriteLine("For edit City  enter - 2");
                        Console.WriteLine("For edit State  enter - 3");
                        Console.WriteLine("For edit Zip  enter - 4");
                        Console.WriteLine("For edit Phone  enter - 5");
                        Console.WriteLine("For edit Email  enter - 6");
                        int edit = Convert.ToInt32(Console.ReadLine());
                        switch (edit)
                        {
                            case 0:
                                Console.WriteLine("Enter the First Name");
                                Contacts.FirstName = Console.ReadLine();
                                break;
                            case 1:
                                Console.WriteLine("Enter the Last Name");
                                Contacts.LastName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter city Name");
                                Contacts.City = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter State Name");
                                Contacts.State = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter Zip ");
                                Contacts.Zip = Convert.ToDouble(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Enter Phone Number");
                                Contacts.PhoneNumber = Convert.ToDouble(Console.ReadLine());
                                break;
                            case 6:
                                Console.WriteLine("Enter Email");
                                Contacts.Email = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Contact not exixt");
                                break;
                        }
                    }

                }
            }
                Display();
        }
        public void DeletingContactINAddressBook(string name)
        {
            Contact remove = new Contact();
            foreach (var contact in persons)
            {
                if (contact.FirstName.Equals(name))
                {
                    remove = contact;
                }
            }
            persons.Remove(remove);
            Display();
        }
        public void Display ()
        {
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
