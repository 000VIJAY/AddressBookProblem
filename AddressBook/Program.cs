using AddressBook;
PersonAddress GetPerson = new PersonAddress();
bool check = true;

while (check)
{
        Console.WriteLine("Enter -0 ,For stop execution");
        Console.WriteLine("Enter-1,For Add the contact");
        Console.WriteLine("Enter -2,For Edit information");
    Console.WriteLine("Enter-3, For delete contact");
    Console.WriteLine("Enter-4,For Add Multiple Unique Addressbook");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 0:
          check = false;
            break;
        case 1:
            GetPerson.Addcontact();
            GetPerson.Book();
            break;
        case 2:
            GetPerson.EditContact();
         break;
        case 3:
            Console.WriteLine("Enter First name for Delete the contact");
            string name = Console.ReadLine();
            GetPerson.DeletingContactINAddressBook(name);
        break;
        case 4:
            Console.WriteLine("Enter name of AddressBook");
            string AddressBookName = Console.ReadLine();
            GetPerson.AddDictionary(AddressBookName);
            break;
    }
}

