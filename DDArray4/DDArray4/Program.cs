class StudentGradesManagement
{
    public string[][] studentNames;  // Jagged array to store student names and their respective grades
    public int[][] studentGrades;    // Jagged array to store grades

    public static void Main(string[] args)
    {
        StudentGradesManagement system = new StudentGradesManagement();
        system.InitializeSystem();

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1) Add Student");
            Console.WriteLine("2) Assign Grade");
            Console.WriteLine("3) Display Grades");
            Console.WriteLine("4) Calculate Average Grade");
            Console.WriteLine("5) Exit");

            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    system.AddStudent();
                    break;
                case 2:
                    system.AssignGrade();
                    break;
                case 3:
                    system.DisplayGrades();
                    break;
                case 4:
                    system.CalculateAverageGrade();
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Method to initialize the system
    private void InitializeSystem()
    {
        Console.WriteLine("Enter the number of students:");
        int numStudents = int.Parse(Console.ReadLine()!);

        studentNames = new string[numStudents][];
        studentGrades = new int[numStudents][];

        for (int i = 0; i < numStudents; i++)
        {
            studentNames[i] = new string[1];  // Initialize with one element for the name
            studentGrades[i] = new int[0];    // Initialize with zero elements for grades
        }
    }

    // Method to add a student
    private void AddStudent()
    {
        Console.WriteLine("Enter the student index (0-based index):");
        int index = int.Parse(Console.ReadLine()!);

        if (index >= 0 && index < studentNames.Length)
        {
            Console.WriteLine("Enter the student's name:");
            string name = Console.ReadLine()!;
            studentNames[index][0] = name;
            Console.WriteLine("Student added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    
    private void AssignGrade()
    {
        Console.WriteLine("Enter the student index (0-based index):");
        int index = int.Parse(Console.ReadLine()!);

        if (index >= 0 && index < studentNames.Length)
        {
            Console.WriteLine("Enter the grade to assign:");
            int grade = int.Parse(Console.ReadLine()!);

            // Create a new array with one more element 
            int[] newGrades = new int[studentGrades[index].Length + 1];
            for (int i = 0; i < studentGrades[index].Length; i++)
            {
                newGrades[i] = studentGrades[index][i];
            }
            newGrades[newGrades.Length - 1] = grade; // adding new grade

            studentGrades[index] = newGrades; 
            Console.WriteLine("Grade assigned successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    
    private void DisplayGrades()
    {
        Console.WriteLine("Current grades of all students:");
        for (int i = 0; i < studentNames.Length; i++)
        {
            Console.Write("Student: " + studentNames[i][0] + " Grades: ");
            for (int j = 0; j < studentGrades[i].Length; j++)
            {
                Console.Write(studentGrades[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    
    private void CalculateAverageGrade()
    {
        for (int i = 0; i < studentNames.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < studentGrades[i].Length; j++)
            {
                sum += studentGrades[i][j];
            }

            double average = 0;
            if (studentGrades[i].Length > 0)
            {
                average = (double)sum / studentGrades[i].Length;
            }

            Console.WriteLine("Student: " + studentNames[i][0] + " Average Grade: " + average);
        }
    }
}
