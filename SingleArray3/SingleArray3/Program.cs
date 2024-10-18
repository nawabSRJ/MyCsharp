using System.Collections.Generic; // for using HashSet
class SetOperations
{ 
    public static void Main(String[] args)
    {
        int[] arr1 = new int[5];
        int[] arr2 = new int[7];

        Console.WriteLine("Enter elements for Array 1:");
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("Enter elements for Array 2:");
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine()!);
        }

        while (true)
        {
            Console.WriteLine("Choose : ");
            Console.WriteLine("1)Union");
            Console.WriteLine("2)Intersection");
            Console.WriteLine("3)Complement");
            Console.WriteLine("4)Difference / Relative Complement");
            Console.WriteLine("5)Exit");
            int choice = int.Parse(Console.ReadLine()!);
            switch (choice)
            {
                case 1:
                    Union(arr1, arr2);
                    break;
                case 2:
                    int[] intersect = Intersection(arr1, arr2);
                    Console.WriteLine("Intersection of 2 Arrays : ");
                    PrintArray(intersect);
                    break;
                case 3:
                    Complement(arr1, arr2);
                    break;
                case 4:
                    Difference(arr1, arr2);
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    } // end of Main
    public static void Union(int[] arr1 , int[] arr2)
    {
        Console.WriteLine("Union of 2 Arrays : ");
        for (int i = 0; i < arr1.Length; i++) 
        { 
            Console.Write(arr1[i]);
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i] + " ");
        }
        Console.WriteLine("\n");
    }
    public static int[] Intersection(int[] arr1, int[] arr2)
    {
        // creating hashset for arr1 :
        HashSet<int> set1 = new HashSet<int>(arr1);
        HashSet<int> intersect = new HashSet<int>();

        foreach(int num in arr2)
        {
            if(set1.Contains(num)) { intersect.Add(num); }
        }

        return intersect.ToArray();
    }
    public static void Complement(int[] arr1, int[] arr2)
    {
        // todo : Get the universal set from user
        Console.WriteLine("Enter the length of the universal set:");
        int length = int.Parse(Console.ReadLine()!);
        int[] universalSet = new int[length];
        Console.WriteLine("Enter elements of the universal set:");
        for (int i = 0; i < length; i++)
        {
            universalSet[i] = int.Parse(Console.ReadLine()!);
        }

        HashSet<int> set1 = new HashSet<int>(arr1);
        HashSet<int> universal = new HashSet<int>(universalSet);
        HashSet<int> complement = new HashSet<int>();

        // Complement of arr1 with respect to universalSet : present in U but not in arr1
        foreach (int num in universal)
        {
            if (!set1.Contains(num))
            {
                complement.Add(num);
            }
        }

        Console.WriteLine("Complement of Array 1 with respect to Universal Set:");
        PrintArray(complement.ToArray());
    }

    public static void Difference(int[] arr1, int[] arr2)
    {
        // todo : arr1 - arr2 , which means unique elements in arr1 which are not present in arr2
        HashSet<int> set1 = new HashSet<int>(arr1);
        HashSet<int> set2 = new HashSet<int>(arr2);
        HashSet<int> difference = new HashSet<int>();

        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                difference.Add(num);
            }
        }

        Console.WriteLine("Difference / Relative Complement of Array 1 with respect to Array 2:");
        PrintArray(difference.ToArray());
    }

    // utility function to print an array
    public static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
} // end of class
