class SlidingWindow
{
    public static void Main(String[] args)
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter elements of the array(once) : ");

        for (int i = 0; i < arr.Length; i++) 
        {
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        while (true)
        {
            Console.WriteLine("Choose : ");
            Console.WriteLine("1)Max Window Sum ");
            Console.WriteLine("2)Min Window Sum");
            Console.Write("Your Choice : ");
            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter window size : ");
                    int wsize = int.Parse(Console.ReadLine()!);
                    if (wsize > arr.Length)
                    {
                        Console.WriteLine("Window size is larger than array size!");
                        return;
                    }
                    else
                    {
                        int ans = MaxWindowSum(arr, wsize);
                        Console.WriteLine("Max Window Sum : " + ans);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter window size : ");
                    int wsize2 = int.Parse(Console.ReadLine()!);
                    if (wsize2 > arr.Length)
                    {
                        Console.WriteLine("Window size is larger than array size!");
                        return;
                    }
                    else
                    {
                        int ans2 = MinWindowSum(arr, wsize2);
                        Console.WriteLine("Min Window Sum : " + ans2);
                    }
                    break;
                    
                default:
                    Console.WriteLine("Please Enter 1 or 2 \n0 to End");
                    break;
            }
        }
    }
    public static int MaxWindowSum(int[] arr, int window)
    {
        int currSum = 0, maxSum = 0;

        // make window
        for (int i = 0; i < window; i++)
        {
            currSum += arr[i];
        }

        maxSum = currSum; // assume

        // sliding the window
        for (int i = window; i < arr.Length; i++)
        {
            currSum += arr[i];
            currSum -= arr[i - window];
            maxSum = Math.Max(maxSum, currSum);
        }
        return maxSum;
    }
    public static int MinWindowSum(int[] arr, int window)
    {
        int currSum = 0, maxSum = 0;

        // make window
        for (int i = 0; i < window; i++)
        {
            currSum += arr[i];
        }

        maxSum = currSum; // assume

        // sliding the window
        for (int i = window; i < arr.Length; i++)
        {
            currSum += arr[i];
            currSum -= arr[i - window];
            maxSum = Math.Min(maxSum, currSum);
        }
        return maxSum;
    }
}