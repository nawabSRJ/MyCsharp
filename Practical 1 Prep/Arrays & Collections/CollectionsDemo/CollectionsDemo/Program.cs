using System.Collections;
class CollectionIntro
{
    public static void Main(string[] args)
    {
        // ListDemo();
        // QueueDemo();
        // DictDemo();
        // StackDemo();
        // HashSetDemo();


        // ListTest();
        DictTest();
    }
    public static void DictTest()
    {
        char al = 'a';
        Dictionary<char, int> alphas = new Dictionary<char, int>();
        for(int i = 1; i <= 26; i++)
        {
            alphas.Add(al, i);
            al++;
        }
        Console.WriteLine($"Here is the alpha mapping dict : ");
        foreach(char i in alphas.Keys) {
            Console.WriteLine($"{i} : {alphas[i]}");
        }
    }
    public static void ListTest()
    {
        List<int> ls = new List<int> { 49, 15, 32, 100, 102, 69, 1, 50, 354, 123, 220 };
        ls.Insert(10, 320);
        Console.WriteLine("List after .Insert : ");
        foreach (int i in ls)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nList after .Sort : ");
        ls.Sort();
        foreach (int i in ls)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n\n");
        int[] arr = ls.ToArray();
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n\n");
    }
    public static void HashSetDemo()
    {
        List<string> hobbies = new List<string>();
        hobbies.Add("Football");
        hobbies.Add("Cricket");
        hobbies.Add("Dancing");
        hobbies.Add("Singing");
        hobbies.Add("Singing");
        hobbies.Add("Cricket");

        // list to hashset : duplicate -> unique containing data structure
        HashSet<string> uniqueHobbies = new HashSet<string>(hobbies);

        Console.WriteLine(uniqueHobbies.Contains("cricket"));  // returns bool value
        Console.WriteLine(uniqueHobbies.Contains("Cricket"));  // case sensitive 

        // traversing / accessing HashSet:
        Console.WriteLine("Items in uniqueHobbies : ");
        foreach (string item in uniqueHobbies)
        {
            Console.WriteLine(item);
        }

    }
    public static void StackDemo()
    {
        // LIFO 
        Stack<int> st = new Stack<int>();
        st.Push(1);
        st.Push(2);
        st.Push(5);
        Console.WriteLine(st.Pop()); 
        Console.WriteLine(st.Peek()); 
    }
    public static void DictDemo()
    {
        // It stores key:value pairs
        Dictionary<int, String> dict1 = new Dictionary<int, string>();
        dict1.Add(1, "Srajan");
        dict1.Add(4, "Pratham");
        dict1.Add(2, "Surya");

        // accessing : through key names
        Console.WriteLine($"The value at key 2 : {dict1[2]}");
        // Console.WriteLine($"The value at key 5 : {dict1[5]}");  // RUN TIME EXCEPTION if key not found

        // traversing / displaying all the key value pairs :
        Console.WriteLine("All the key value pairs : ");
        foreach (int key in dict1.Keys) {
            Console.WriteLine($"{key} : {dict1[key]}");
        }

        // using var in loop
        Console.WriteLine("Using a different method to display : ");
        foreach (var item in dict1)
        {
            Console.WriteLine(item);
            Console.WriteLine(item.Key);    // 'K' is capital and so is 'V' below
            Console.WriteLine(item.Value);
        }
    }
    public static void QueueDemo()
    {
        // FIFO
        // creation
        Queue myq = new Queue(); // 'using System.Collections' is mandatory
        
        myq.Enqueue(1);
        myq.Enqueue("Srajan");
        myq.Enqueue("Aaditya");
        myq.Enqueue(true);
        myq.Dequeue();  // removes object from the beginning of the queue
        // traversing / accessing :
        foreach(var item in myq)
        {
            Console.WriteLine(item);
        }

        // to make a particular type of queue
        Queue<int>que2 = new Queue<int>();
        que2.Enqueue(4);
        que2.Enqueue(1);
        que2.Enqueue(3);
        que2.Enqueue(2);
        // items are access in the way inserted FIFO , peek : 4
        foreach (int item in que2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"This is the peek on que2 : {que2.Peek()}");
    }
    public static void ListDemo()
    {
        // lists : ways to add elements
        List<int> ls1 = new List<int>();
        List<int> ls2 = new List<int> { 10, 50, 15, 35 };
        // for adding items in list

        for (int i = 1; i <= 5; i++)
        {
            ls1.Add(i * 2);
        }

        // traversing / accessing :
        Console.WriteLine("Items in ls 1: ");
        foreach (int item in ls1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Items in ls 2: ");
        foreach (int item in ls2)
        {
            Console.WriteLine(item);
        }
        // removal : 
        // .Remove(element) : removes the element
        // .RemoveAt(index) : removes from the specified index
        ls1.Remove(2);
        ls1.RemoveAt(2);
        Console.WriteLine("Items in ls 1 after removal : ");
        foreach (int item in ls1)
        {
            Console.WriteLine(item);
        }
        ls1.Reverse();
        Console.WriteLine("Items in ls 1 after reversal: ");
        foreach (int item in ls1)
        {
            Console.WriteLine(item);
        }

        // sorting : .sort()
        ls2.Sort();
        Console.WriteLine("Items in ls 2 after sorting : ");
        foreach (int item in ls2)
        {
            Console.WriteLine(item);
        }
    }
}