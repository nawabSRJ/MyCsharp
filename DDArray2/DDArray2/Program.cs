using System;

class NumpyArrays
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n\nMake Choice :\n1->Zeros Array\n2->Ones Array\n" +
                "3->Regular Shaped Array\n" +
                "4->Identity Matrix\n0->Exit\n\nChoose : ");
            NumpyArrays obj = new NumpyArrays();

            int choice = int.Parse(Console.ReadLine()!);
            int r, c, s;
            int[] oneD;
            int[,] twoD;

            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("Enter Rows : ");
                    r = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Enter Columns : ");
                    c = int.Parse(Console.ReadLine()!);
                    twoD = obj.ZerosArray(r, c);
                    Console.WriteLine("Array Created : \n\n");
                    obj.ShowNumpyArray(twoD);
                    break;

                case 2:
                    Console.WriteLine("Enter Rows : ");
                    r = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Enter Columns : ");
                    c = int.Parse(Console.ReadLine()!);
                    twoD = obj.OnesArray(r, c);
                    Console.WriteLine("Array Created : \n\n");
                    obj.ShowNumpyArray(twoD);
                    break;

                case 3:
                    Console.WriteLine("Enter Starting Value : ");
                    r = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Enter End Value(excluded) : ");
                    c = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Enter Step/Stride Value : ");
                    s = int.Parse(Console.ReadLine()!);
                    oneD = obj.RegularShapedArray(r, c, s);
                    Console.WriteLine("Array Created : \n\n");
                    obj.ShowOneDArray(oneD);
                    break;

                case 4:
                    Console.WriteLine("Enter Size : ");
                    r = int.Parse(Console.ReadLine()!);
                    twoD = obj.IdentityMatrix(r);
                    Console.WriteLine("Array Created : \n");
                    obj.ShowNumpyArray(twoD);
                    break;

                default:
                    break;
            }
        }
    }    // MAIN ENDS

    void ShowOneDArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            Console.Write(" ");
        }
        Console.Write("\b]");    // backspace escape sequence
    }

    void ShowNumpyArray(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        Console.Write("[");
        for (int i = 0; i < rows; i++)
        {
            Console.Write("[");  // for row
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j]);
                Console.Write(" ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
        Console.Write("\b]");
    }

    int[,] ZerosArray(int rows, int cols)
    {
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = 0;
            }
        }
        return result;
    }

    int[,] OnesArray(int rows, int cols)
    {
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = 1;
            }
        }
        return result;
    }

    int[] RegularShapedArray(int start, int end, int steps)
    {
        int size = (end - start) / steps;
        int[] result = new int[size];
        int k = 0;
        for (int i = start; i < end; i += steps)
        {
            result[k] = i;
            k++;
        }
        return result;
    }

    int[,] IdentityMatrix(int size)
    {
        int[,] result = new int[size, size];  // here rows = cols
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == j)
                {
                    result[i, j] = 1;   // diagonal dominant
                }
                else
                {
                    result[i, j] = 0;
                }
            }
            Console.WriteLine();
        }
        return result;
    }
} // class ends
