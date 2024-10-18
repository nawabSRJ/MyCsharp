class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter name : ");
        string x = Console.ReadLine()!;
        string result = "";
        for (int i = 0; i < x.Length; i++)
        {
            if (char.IsUpper(x[i]))
            {
                result += char.ToLower(x[i]);
            }
            else if (char.IsLower(x[i]))
            {
                result += char.ToUpper(x[i]);
            }
            else
            {
                result += x[i]; // keeping non-alpha chars unchanged
            }
        }

        Console.WriteLine("Converted string: " + result);
    }
}