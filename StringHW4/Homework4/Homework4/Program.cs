class ArrangeLetters
{
    public static void Main(string[] args)
    {
        Arrange("bca");
    }
    public static void Arrange(string x)
    {
        Console.WriteLine($"Given : {x}");
        x = x.ToUpper();
        Console.WriteLine($"In Upper Case : {x}");
        // now converting in uppercase
        char[] arr = x.ToCharArray();
        for(int i = 0; i < arr.Length - 1; i++)
        {
            for(int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // swap
                    char temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        String ans = new String(arr);
        Console.WriteLine($"After Sort : {ans}");
        
    }
}