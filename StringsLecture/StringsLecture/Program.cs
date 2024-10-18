class Program
{
    public static void Main(string[] args)
    {
        string x = "hello java java";
        // Object y = x.Clone(); Console.WriteLine(y);  
        Console.WriteLine(x);  
        
        int d = x.CompareTo("hEllo");
        Console.WriteLine(d);

        bool check = x.Contains("ll");
        Console.WriteLine("Present : " + check);

        Console.WriteLine(x.EndsWith("llo"));

        int ind = x.IndexOf("rfgre" , 7); // first occurence
        Console.WriteLine(ind);
        char[] arr = {'j' , 'h'};  // using [] is also working? how?
        int ind2 = x.IndexOfAny(arr);
        Console.WriteLine(ind2);

        Console.WriteLine(x.LastIndexOf("java"));
        Console.WriteLine(true); // why the output is in 'T' capital ?

        Console.WriteLine(x.Length);
        string z = x.Insert(2, " Heya ");
        Console.WriteLine(z);

        string x2 = "hello";
        string p = x2.PadLeft(10 + x2.Length , '$');    // first arg takes totalLength which means you have to calculate the 
        // final length of the original string + the pad str value ($ here ) 
        // due to which the minimum value in the left arg should > x2.Length !!

        string p2 = x2.PadLeft(x2.Length + 2, '#'); 
        Console.WriteLine(p);
        Console.WriteLine(p2);

        string rem = x2.Remove(4);  // removes from the startIndex to end of string
        string rem2 = x2.Remove(1, 3);  // 'ell' removed which means it is inclusive of end index
        Console.WriteLine(rem);
        Console.WriteLine(rem2);

        string rep = x2.Replace("he", "she");
        Console.WriteLine(rep);

        string sub = x2.Substring(0, 3);    // last index exclusive
        Console.WriteLine(sub);

        Console.WriteLine("Starts with 'he' : " + x2.StartsWith("he"));    
        Console.WriteLine("Starts with 'she' : " + x2.StartsWith("she"));

        string x3 = "     SRJ     ";
        Console.WriteLine(x3.ToLower());
        Console.WriteLine(x2.ToUpper());

        Console.WriteLine(x3.Trim()); // trims space from both sides
        Console.WriteLine(x3.TrimEnd());    // trims space from ending side or right side
        Console.Write(x3.TrimStart());Console.Write("..");

    }
}