class Ksmall
{
    // todo - find the kth smallest element in an array
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter size of the array : ");
        int N = int.Parse(Console.ReadLine()!);
        int[] arr = new int[N];
        Console.WriteLine("Enter elements of the array : ");
        for (int i = 0; i < arr.Length; i++) 
        {
            arr[i] = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine("Enter value of k : ");
        int k = int.Parse(Console.ReadLine()!);
        // to find the kth smallest , sort and then return kth element (used bubble sort)
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = 0; j < N - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j + 1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine($"{k}th smallest element is : {arr[k-1]}");   // 1-based index

    }
    
}