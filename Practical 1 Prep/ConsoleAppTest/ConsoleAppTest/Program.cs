class Test
{
    public static void Main(string[] args)
    {
        reverse(123 , "123");
    }
    public static void reverse(int num , string x)
    {
        // reversing number
        int rev = 0;
        while (num > 0) { 
            int rem = num % 10;
            rev = rev * 10 + rem;
            num /= 10;            
        }
        Console.WriteLine($"The reversed number is : {rev}");

        // reversing string
        string temp = "";
        for(int i = x.Length - 1; i >= 0; i--)
        {
            temp += x[i];
        }
        Console.WriteLine($"The reversed string is : {temp}");
    }
}