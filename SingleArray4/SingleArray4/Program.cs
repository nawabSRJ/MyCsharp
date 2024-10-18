class RunningSum
{
    public static void Main(String[] args)
    {
        //int[] arr = new int[10];
        int[] arr = [1,2,3,4,5];
        Console.WriteLine("Enter the elements of the original array : ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine()!);
        }
        int[] ans = PrefixSum(arr);
        Console.WriteLine("Running Sum Array : ");
        for (int i = 0; i < ans.Length; i++)
        {
            Console.Write(ans[i] + " ");
        }
        Console.WriteLine("\n");

    }
    public static int[] PrefixSum(int[] arr)
    {
        int s = arr[0];
        int[] ans = new int[arr.Length];
        ans[0] = s;
        for (int i = 1; i < arr.Length; i++)
        {
            s += arr[i];
            ans[i] = s;
        }
        return ans;
    }
}