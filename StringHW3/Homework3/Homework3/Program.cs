class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string : ");
        string x = Console.ReadLine()!;
        x = x.ToLower();
        string ans = "";
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == 'a' || x[i] == 'e' || x[i] == 'i' || x[i] == 'o' || x[i] == 'u')
            {
                ans += (char)(x[i] + 1);
            }
            else
            {
                ans += x[i];
            }

        }
        Console.WriteLine($"Modified String : {ans}");
    }
}