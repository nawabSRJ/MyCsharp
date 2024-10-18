class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string : ");
        string x = Console.ReadLine()!;
        Console.WriteLine($"The original String : {x}");
        // converting to capital
        x = x.ToUpper();
        // adding 2 in each character
        string ans = "";
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == ' ')
            {
                ans += ' ';   // keep spaces consistent
                continue;
            }
            if (x[i] + 2 > 'Z')
            {
                ans += (char)((x[i] + 2) - 26);
            }
            else
            {
                ans += (char)(x[i] + 2);
            }
            
        }
        
        Console.WriteLine($"The modified string : {ans}"); 
    }
}