using AddressBook;
PersonAddress GetPerson = new PersonAddress();
bool check = true;

while (check)
{
        Console.WriteLine("Enter -0 ,For stop execution");
        Console.WriteLine("Enter-1,For Add the information /n");
        Console.WriteLine("Enter -2,For Edit information");
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
            string name = Console.ReadLine();
            GetPerson.EditContact()
        ; break;
    }
}

