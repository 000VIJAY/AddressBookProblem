using AddressBook;
PersonAddress GetPerson = new PersonAddress();
bool check = true;

while (check)
{
        Console.WriteLine("Enter -0 ,For stop execution");
        Console.WriteLine("Enter-1,For display the information /n");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 0:
          check = false;
            break;
        case 1:
            GetPerson.Show();
            GetPerson.Book();
            break;
    }
}

