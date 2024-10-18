using System;

class Bank
{
    private int[,] SavingAccounts = new int[10, 2];
    private int count = 0;
    private const int TOTAL_ACC = 10;
    private static readonly Bank obj = new Bank();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter Your Choice : \n1->Open Account\n2->Close Account\n3->Access Account\n4->Exit");
            int choice = int.Parse(Console.ReadLine()!);
            switch (choice)
            {
                case 1:
                    obj.CreateAccount();
                    break;
                case 2:
                    obj.CloseAccount();
                    break;
                case 3:
                    obj.AccessAccount();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    void CreateAccount()
    {
        if (count >= TOTAL_ACC)
        {
            Console.WriteLine("Sorry, we cannot accommodate more Customers");
            return;
        }

        int accId;
        bool isDuplicate;
        do
        {
            Console.WriteLine("Enter Account id : ");
            accId = int.Parse(Console.ReadLine()!);

            isDuplicate = (accId == 0) || IsIdDuplicate(accId);

            if (isDuplicate)
            {
                Console.WriteLine("Account Id is either 0 or already taken. Enter Again");
            }
        } while (isDuplicate);

        Console.WriteLine("Enter the amount to deposit : ");
        int amt = int.Parse(Console.ReadLine()!);
        SavingAccounts[count, 0] = accId;
        SavingAccounts[count, 1] = amt;
        count++;    // To keep track of Bank SavingAccounts
    }

    bool IsIdDuplicate(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (SavingAccounts[i, 0] == id)
            {
                return true; // ID already exists
            }
        }
        return false; // ID does not exist
    }

    void CloseAccount()
    {
        Console.WriteLine("Enter the Account id : ");
        int accId = int.Parse(Console.ReadLine()!);
        bool found = false;
        for (int i = 0; i < TOTAL_ACC; i++)
        {
            if (SavingAccounts[i, 0] == accId)
            {
                found = true;
                SavingAccounts[i, 0] = 0;
                SavingAccounts[i, 1] = 0;
            }
        }
        if (!found)
        {
            Console.WriteLine("Sorry, account not found");
        }
    }

    void AccessAccount()
    {
        Console.WriteLine("Enter the Account id : ");
        int accId = int.Parse(Console.ReadLine()!);
        bool found = false;
        for (int i = 0; i < TOTAL_ACC; i++)
        {
            if (SavingAccounts[i, 0] == accId)
            {
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Sorry, account not found");
            return;
        }
        Console.WriteLine("Enter the action to be performed :\n1->Deposit\n2->Withdraw\n3->Balance Enquiry\n");
        int choice = int.Parse(Console.ReadLine()!);
        int amt;
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter amount to be deposited:");
                amt = int.Parse(Console.ReadLine()!);
                for (int i = 0; i < TOTAL_ACC; i++)
                {
                    if (SavingAccounts[i, 0] == accId)
                    {
                        SavingAccounts[i, 1] += amt;
                        Console.WriteLine("Do you want to display balance?\n[yes -> 1/ no -> 0]");
                        int cho = int.Parse(Console.ReadLine()!);
                        if (cho == 1)
                        {
                            Console.WriteLine("New Bank Balance : " + SavingAccounts[i, 1]);
                        }
                    }
                }
                break;

            case 2:
                Console.WriteLine("Enter Amount to withdraw :");
                amt = int.Parse(Console.ReadLine()!);
                for (int i = 0; i < TOTAL_ACC; i++)
                {
                    if (SavingAccounts[i, 0] == accId)
                    {
                        SavingAccounts[i, 1] -= amt;
                        Console.WriteLine("Do you want to display balance?\n[yes -> 1/ no -> 0]");
                        int cho = int.Parse(Console.ReadLine()!);
                        if (cho == 1)
                        {
                            Console.WriteLine("New Bank Balance : " + SavingAccounts[i, 1]);
                        }
                    }
                }
                break;

            case 3:
                for (int i = 0; i < TOTAL_ACC; i++)
                {
                    if (SavingAccounts[i, 0] == accId)
                    {
                        Console.WriteLine("Bank Balance : " + SavingAccounts[i, 1]);
                    }
                }
                break;

            default:
                Console.WriteLine("Invalid choice, please try again.");
                break;
        }
    }
}
