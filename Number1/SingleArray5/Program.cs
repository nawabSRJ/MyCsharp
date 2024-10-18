class GoldenBatchNumber
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter Number : ");
        int num = int.Parse(Console.ReadLine()!);
        for (int i = 1; i < num / 2; i++)
        {
            if (isPrime(i) && isPrime(num - i))
            {
                Console.WriteLine(i + " + " + (num - i));
            }
        }
    }
    public static bool isPrime(int num)
    {
        for (int i = 2; i < num; i++) 
        {
            if(num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    
}