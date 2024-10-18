enum Days { 
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,        
}

class Program {
    public static void Main(string[] args) { 
        Days obj = Days.Monday;
        Days today = Days.Sunday;
        Console.WriteLine((int)today);
        Console.WriteLine($"Today is {today}");
        Console.WriteLine($"Tomorrow is {(int)today + 1}");
        
    }
}