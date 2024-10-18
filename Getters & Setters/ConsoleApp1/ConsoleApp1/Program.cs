class Test1 {
    //   getter - setter without property
    public int a;
    public void set(int x)
    {
        this.a = x;
    }
    public int get() {
        return a;
    }
}
class Test2 {
    // getter - setter with property

    // Auto-implemented
    // Syntax : AccessSpecifier Datatype propertyName {get;set;}

    public int a { get; set; }
    public int b { get; }

    public int Add() { return a + b; }

}
class Student {
    // with get - set function notation
    public int _id;
    public string _name;
    public int _passMark = 40; // readonly
    public int ID
    {
        set
        {
            if(value < 0)  // ? is value a keword here?
            {
                throw new Exception("Keep it > 0");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null");
            }
            this._name = value;
        }
        get
        {
            return this._name;
        }
    }
    // for a readonly property
    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }

}

class Program
{
    public static void Main(string[] args)
    {/*
        Test1 obj1 = new Test1();
        obj1.set(100);
        Console.WriteLine(obj1.get());

        // ------------------------------------------------

        Test2 obj2 = new Test2();
        obj2.a = 20;
        //obj2.b = 20;  cannot be done , since b is read only
        Console.WriteLine(obj2.a);
        Console.WriteLine(obj2.Add());
        Console.WriteLine("\n");
        // ------------------------------------------------
        Student stu = new Student();
        stu.ID = 35;
        stu.Name = "Srajan";
        Console.WriteLine($"PASS MARKS {stu.PassMark}");
        Console.WriteLine($"Student ID : {stu.ID}");
        Console.WriteLine($"Student Name : {stu.Name}");
        */
        int a = int.Parse(Console.ReadLine()!);
        string str = Console.ReadLine()!;
        int num = 10;
        //Console.WriteLine(num.ToString());
    }
}
