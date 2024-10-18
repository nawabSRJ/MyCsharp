using System;
class Employee
{
    // using getters and setters
    public string Name { get; set; }
    public int EmpId { get; set; }
    public double BasicSalary { get; set; }

    // Common allowances and deductions
    public double Ta { get; set; }
    public double Da { get; set; }
    public double Hra { get; set; }
    public double Ppf { get; set; }

    public Employee(string name, int empId, double basicSalary)
    {
        Name = name;
        EmpId = empId;
        BasicSalary = basicSalary;
        Ta = basicSalary * 0.10;  // assuming percentage
        Da = basicSalary * 0.05;  // 5 % of salary 
        Hra = basicSalary * 0.15; // 15 % of salary
        Ppf = basicSalary * 0.08; // 8 % of salary
    }

    // Virtual method to calculate salary
    public virtual double CalculateSalary()
    {
        return BasicSalary + Ta + Da + Hra - Ppf;
    }

    public virtual void DisplaySalarySlip()
    {
        Console.WriteLine($"Name: {Name}, Emp ID: {EmpId}, Total Salary: {CalculateSalary()}");
    }
}

class Developer : Employee
{
    public double Incentive { get; set; }
    // name , empId , basicSalary are coming from the base class using the 'base' class constructor
    public Developer(string name, int empId, double basicSalary, double incentive)
        : base(name, empId, basicSalary)
    {
        Incentive = incentive;
    }

    public override double CalculateSalary()
    {
        return base.CalculateSalary() + Incentive;
    }

    public override void DisplaySalarySlip()
    {
        base.DisplaySalarySlip();
        Console.WriteLine($"Incentive: {Incentive}, Net Salary: {CalculateSalary()}");
    }
}

class Backoffice : Employee
{
    public double Incentive { get; set; }

    
    public Backoffice(string name, int empId, double basicSalary, double incentive)
        : base(name, empId, basicSalary)
    {
        Incentive = incentive;
    }

    public override double CalculateSalary()
    {
        return base.CalculateSalary() + Incentive;
    }

    public override void DisplaySalarySlip()
    {
        base.DisplaySalarySlip();
        Console.WriteLine($"Incentive: {Incentive}, Net Salary: {CalculateSalary()}");
    }
}

class Tester : Employee
{
    public double ProjectIncentive { get; set; }
    public double ReportIncentive { get; set; }
    public int NumberOfProjects { get; set; }
    public int NumberOfReports { get; set; }

    public Tester(string name, int empId, double basicSalary, int numberOfProjects, int numberOfReports)
        : base(name, empId, basicSalary)
    {
        NumberOfProjects = numberOfProjects;
        NumberOfReports = numberOfReports;
        ProjectIncentive = 100 * numberOfProjects;  // Example calculation
        ReportIncentive = 50 * numberOfReports;     // Example calculation
    }

    public override double CalculateSalary()
    {
        return base.CalculateSalary() + ProjectIncentive + ReportIncentive;
    }

    public override void DisplaySalarySlip()
    {
        base.DisplaySalarySlip();
        Console.WriteLine($"Project Incentive: {ProjectIncentive}, Report Incentive: {ReportIncentive}, Net Salary: {CalculateSalary()}");
    }
}

class Market : Employee
{
    public double Incentive { get; set; }

    public Market(string name, int empId, double basicSalary, double incentive)
        : base(name, empId, basicSalary)
    {
        Incentive = incentive;
    }

    public override double CalculateSalary()
    {
        return base.CalculateSalary() + Incentive;
    }

    public override void DisplaySalarySlip()
    {
        base.DisplaySalarySlip();
        Console.WriteLine($"Incentive: {Incentive}, Net Salary: {CalculateSalary()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Developer");
        Console.WriteLine("2. Backoffice");
        Console.WriteLine("3. Tester");
        Console.WriteLine("4. Market");
        Console.WriteLine("Enter your choice (1-4): ");

        int choice = int.Parse(Console.ReadLine()!);

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter Developer Details:");
                Developer developer = new Developer("Alice", 101, 50000, 3000);
                developer.DisplaySalarySlip();
                break;
            case 2:
                Console.WriteLine("Enter Backoffice Details:");
                Backoffice backoffice = new Backoffice("Bob", 102, 40000, 2000);
                backoffice.DisplaySalarySlip();
                break;
            case 3:
                Console.WriteLine("Enter Tester Details:");
                Tester tester = new Tester("Charlie", 103, 45000, 5, 10);
                tester.DisplaySalarySlip();
                break;
            case 4:
                Console.WriteLine("Enter Market Details:");
                Market market = new Market("David", 104, 55000, 4000);
                market.DisplaySalarySlip();
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
