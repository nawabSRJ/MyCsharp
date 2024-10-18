using System;

interface IAccount
{
    void Deposit(double amount);
    void Withdraw(double amount);
    void ViewBalance();
    double CalculateInterest();
}

class Bank
{
    private SavingsAccount[] savingsAccounts = new SavingsAccount[100];
    private CurrentAccount[] currentAccounts = new CurrentAccount[100];
    private int savingsCount = 0;
    private int currentCount = 0;
    private static int accountIdCounter = 1;

    public void AddSavingsAccount(string name, double initialDeposit)
    {
        SavingsAccount newAccount = new SavingsAccount(name, accountIdCounter, initialDeposit);
        savingsAccounts[savingsCount++] = newAccount;
        Console.WriteLine($"Savings Account created successfully with Account ID: {accountIdCounter}");
        accountIdCounter++;
    }

    public void AddCurrentAccount(string name, double initialDeposit)
    {
        CurrentAccount newAccount = new CurrentAccount(name, accountIdCounter, initialDeposit);
        currentAccounts[currentCount++] = newAccount;
        Console.WriteLine($"Current Account created successfully with Account ID: {accountIdCounter}");
        accountIdCounter++;
    }

    public void ManageAccount()
    {
        Console.Write("Enter Account ID to manage: ");
        int accountId = int.Parse(Console.ReadLine());

        bool accountFound = false;

        for (int i = 0; i < savingsCount; i++)
        {
            if (savingsAccounts[i].AccountId == accountId)
            {
                accountFound = true;
                Console.WriteLine($"\nManaging Savings Account (ID: {accountId}) for {savingsAccounts[i].Name}");
                ManageAccountActions(savingsAccounts[i]);
                break;
            }
        }

        if (!accountFound)
        {
            for (int i = 0; i < currentCount; i++)
            {
                if (currentAccounts[i].AccountId == accountId)
                {
                    accountFound = true;
                    Console.WriteLine($"\nManaging Current Account (ID: {accountId}) for {currentAccounts[i].Name}");
                    ManageAccountActions(currentAccounts[i]);
                    break;
                }
            }
        }

        if (!accountFound)
        {
            Console.WriteLine("Account not found!");
        }
    }

    private void ManageAccountActions(IAccount account)
    {
        while (true)
        {
            Console.WriteLine("\n1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. View Balance");
            Console.WriteLine("4. Exit Account Management");
            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;
                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    break;
                case 3:
                    account.ViewBalance();
                    break;
                case 4:
                    Console.WriteLine("Exiting Account Management.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    public void DisplayAllAccounts()
    {
        Console.WriteLine("\n--- Savings Accounts ---");
        for (int i = 0; i < savingsCount; i++)
        {
            Console.WriteLine($"Account Holder: {savingsAccounts[i].Name}, Balance: {savingsAccounts[i].Balance}, Account ID: {savingsAccounts[i].AccountId}");
        }

        Console.WriteLine("\n--- Current Accounts ---");
        for (int i = 0; i < currentCount; i++)
        {
            Console.WriteLine($"Account Holder: {currentAccounts[i].Name}, Balance: {currentAccounts[i].Balance}, Account ID: {currentAccounts[i].AccountId}");
        }
    }
}


class SavingsAccount : IAccount
{
    public string Name { get; private set; }
    public int AccountId { get; private set; }
    public double Balance { get; private set; }

    public SavingsAccount(string name, int accountId, double initialDeposit)
    {
        Name = name;
        AccountId = accountId;
        Balance = initialDeposit;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount}, new balance is {Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}, new balance is {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public void ViewBalance()
    {
        Console.WriteLine($"Balance: {Balance}");
    }

    public double CalculateInterest()
    {
        return Balance * 0.04;
    }
}

class CurrentAccount : IAccount
{
    public string Name { get; private set; }
    public int AccountId { get; private set; }
    public double Balance { get; private set; }

    public CurrentAccount(string name, int accountId, double initialDeposit)
    {
        Name = name;
        AccountId = accountId;
        Balance = initialDeposit;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount}, new balance is {Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}, new balance is {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public void ViewBalance()
    {
        Console.WriteLine($"Balance: {Balance}");
    }

    public double CalculateInterest()
    {
        return Balance * 0.03;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();
        while (true)
        {
            Console.WriteLine("\n1. Create Savings Account");
            Console.WriteLine("2. Create Current Account");
            Console.WriteLine("3. Manage Account");
            Console.WriteLine("4. Display All Accounts");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Name: ");
                    string savingsName = Console.ReadLine();
                    Console.Write("Enter Initial Deposit: ");
                    double savingsDeposit = double.Parse(Console.ReadLine());
                    bank.AddSavingsAccount(savingsName, savingsDeposit);
                    break;

                case 2:
                    Console.Write("Enter Name: ");
                    string currentName = Console.ReadLine();
                    Console.Write("Enter Initial Deposit: ");
                    double currentDeposit = double.Parse(Console.ReadLine());
                    bank.AddCurrentAccount(currentName, currentDeposit);
                    break;

                case 3:
                    bank.ManageAccount();
                    break;

                case 4:
                    bank.DisplayAllAccounts();
                    break;

                case 5:
                    Console.WriteLine("Exiting the system...");
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
