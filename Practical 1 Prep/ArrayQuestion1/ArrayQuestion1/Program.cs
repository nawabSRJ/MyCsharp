class SeatBooking
{
    public int[][] seating;

    public static void Main(string[] args)
    {
        SeatBooking obj = new SeatBooking();
        obj.InitializeSeating();
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1) Book Seat");
            Console.WriteLine("2) Cancel Reservation");
            Console.WriteLine("3) Display Seating Arrangement");
            Console.WriteLine("4) Exit");

            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    obj.BookSeat();
                    break;
                case 3:
                    obj.DisplaySeatingArrangement();
                    break;
                case 4:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

    }
    public void InitializeSeating()
    {
        Console.WriteLine("Enter the no. of rows : ");
        int rows = int.Parse(Console.ReadLine()!);

        seating = new int[rows][];

        // allot no. of seats (cols) for each row
        for(int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Enter the no. of seats for row {i + 1}");
            int seats = int.Parse(Console.ReadLine()!);
            seating[i] = new int[seats];

            // set seats as 0 -> not booked
            for(int j = 0; j < seats; j++)
            {
                seating[i][j] = 0; // 1->booked , 0->not booked
            }
        }
    }

    // method to book a seat
    public void BookSeat()
    {
        Console.WriteLine("Enter the row number : ");
        int rowNum = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter seat number : ");
        int seatNum = int.Parse(Console.ReadLine()!);

        if(rowNum >= 0 && rowNum < seating.Length && 
            seatNum >=0 && seatNum < seating[rowNum].Length)
        {
            seating[rowNum][seatNum] = 1; // booked
        }
        else
        {
            Console.WriteLine("Invalid Row or Seat number.");
        }
    }
    public void DisplaySeatingArrangement()
    {
        Console.WriteLine("Current Seating Arrangement : ");
        for (int i = 0; i < seating.Length; i++)
        {
            Console.Write($" Row {i} : ");
            for (int j = 0; j < seating[i].Length; j++)
            {
                Console.Write(seating[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}