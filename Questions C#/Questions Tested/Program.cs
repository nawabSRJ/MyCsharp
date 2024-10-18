// Question 1 : how to make aliases of namespace?
using Sys = System;
class TestAlias {
    public static void Main(string[] args) {

        Console.WriteLine("To make aliases of namespace , assign it just normally to an identifier using '=' ");

        // Question 2 : How to print escape sequence characters?
        Console.WriteLine("F:\\n# SEM 5\\Questions C#");    // method 1 


        // Question 3 : how to use quotes in a string?
        Console.WriteLine("Hi there , my name is \'Srajan\' ");
        Console.WriteLine("Hi there , my name is \"Srajan\" ");

        // Question 4 : How to use foreach loop and "in" & "out" keyword
        int[] arr = {1, 2, 3 , 4};
        foreach (int i in arr) Console.WriteLine(i);

        // out keyword is used in 2 ways
        // Method 1 : as pass by reference
        int val = 10;
        func1(out val);
    }

    public static void func1(out int val)
    {
        val = 2;
        Console.WriteLine($"This is val : {val}");
    }
}