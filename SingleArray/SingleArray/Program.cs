class PhoneBook
{
    public static void Main(String[] args)
    {
        String[] names = new String[10];  // at max Ten Contacts
        int[] numbers = new int[10]; // for corresponding 10 phone numbers
        int total = 0;

        while (true)
        {
            Console.WriteLine("Make Choice : ");
            Console.WriteLine("1)Add Contact");
            Console.WriteLine("2)Search Contact");
            Console.WriteLine("3)Edit Contact");
            Console.WriteLine("4)Delete Contact");
            Console.WriteLine("0)Exit");

            int choice = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Your Choice : " + choice);

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Terminating...");
                    Environment.Exit(1);    // exits the application , similar to exit(1) in C++
                    break;
                case 1:
                    Console.WriteLine("Enter Name of Contact : ");
                    String tempName = Console.ReadLine()!;
                    Console.WriteLine("Enter the Phone Number : ");
                    int tempnumber = int.Parse(Console.ReadLine()!);

                    AddContact(tempName, tempnumber, names, numbers, ref total );
                    break;
                case 2:
                    SearchContact(numbers, names, total);
                    break;
                case 3:
                    Console.WriteLine("Enter Contact Name : ");
                    String cname = Console.ReadLine()!;
                    EditContact(names, numbers, cname, ref total);
                    break;
                case 4:
                    DeleteContact(names, numbers, ref total);
                    break;
                default:
                    Console.WriteLine("Please Choose between 1 - 4");
                    break;
            } // end of switch
        }
    } // end of Main

    public static void AddContact(String name, int number, String[] names, int[] numbers, ref int total)
    {
        if (!(total <= 10))
        {
            Console.WriteLine("Cannot add more contacts!!");
            return;
        }

        names[total] = name;
        numbers[total] = number;
        Console.WriteLine("Contact " + names[total] + " saved with number : " + numbers[total]);
        total++; // increase total count
        return;

    }
    public static void SearchContact(int[] numbers, String[] names , int total)
    {
        if(total == 0)
        {
            Console.WriteLine("Sorry , but there are no contacts as of now!!"); 
            return;
        }
        Console.WriteLine("On what basis : ");
        Console.WriteLine("1)Phone Number \n2)Contact Name");
        int ch = int.Parse(Console.ReadLine()!);
        switch (ch)
        {
            case 1:
                Console.WriteLine("Enter Phone Number : ");
                int tempNumber = int.Parse(Console.ReadLine()!);
                String holder = SearchByNumber(tempNumber, numbers, names);
                Console.WriteLine("The number " + tempNumber + " is held by " + holder);
                return;
            case 2:
                Console.WriteLine("Enter Contact Name : ");
                String tempName = Console.ReadLine()!;
                int answer = SearchByName(tempName, numbers, names , total);
                if(answer == -1)
                {
                    Console.WriteLine("Not found!!");
                    return;
                }
                Console.WriteLine("Phone number of " + tempName + " is " + answer);
                return;

            default:
                Console.WriteLine("Please Enter a valid choice");
                break;

        }

    }
    public static String SearchByNumber(int tempNumber, int[] numbers, String[] names)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == tempNumber)
            {
                return names[i];
            }
        }
        return "Not found!!";
    }


    public static int SearchByName(String tempName, int[] numbers, String[] names, int total)
    {
        for (int i = 0; i < total; i++)
        {
            if (names[i].Equals(tempName, StringComparison.OrdinalIgnoreCase))
            {
                return numbers[i];
            }
        }
        return -1; // Indicates that the contact was not found
    }
    public static void EditContact(String[] names, int[] numbers ,String cname ,ref int total)
    {
        // check if the contact exists:
        int check = SearchByName(cname, numbers, names, total);
        if(check == -1)
        {
            Console.WriteLine("Contact dosen't exist!!");
            return;
        }
        Console.WriteLine("Enter new name of the contact : ");
        String newName = Console.ReadLine()!;
        Console.WriteLine("Enter new number of the contact : ");
        int newNumber = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < total; i++)
        {
            if (names[i].Equals(cname, StringComparison.OrdinalIgnoreCase))
            {
                numbers[i] = newNumber; // number changed
                names[i] = newName; ;   // name changed
                Console.WriteLine("Now "+ names[i] + "'s phone number is " + numbers[i]);
                return;
            }
        }
    }
    public static void DeleteContact(String[] names, int[] numbers, ref int total)
    {
        Console.WriteLine("Enter the name of the contact to delete: ");
        String nameToDelete = Console.ReadLine()!;

        int indexToDelete = -1;
        for (int i = 0; i < total; i++)
        {
            if (names[i].Equals(nameToDelete, StringComparison.OrdinalIgnoreCase))
            {
                indexToDelete = i;
                break;
            }
        }

        if (indexToDelete == -1)
        {
            Console.WriteLine("Contact not found!");
            return;
        }

        for (int i = indexToDelete; i < total - 1; i++)
        {
            names[i] = names[i + 1];
            numbers[i] = numbers[i + 1];
        }

        names[total - 1] = null;  // setting the last element to null and 0 
        numbers[total - 1] = 0;   

        total--;  
        Console.WriteLine("Contact deleted successfully!");
    }
} // end of class

// Learnings :

 /* In C#, the ref keyword is used to pass arguments by reference, rather than by value.
This means that any changes made to the parameter inside the method will be reflected outside the
 method, because the method operates on the original variable, not a copy of it. */