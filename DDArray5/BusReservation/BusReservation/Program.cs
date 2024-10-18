using System;
class BusReservation
{
    public int[][] Seats;
    // initialize with 0s
    
    public static void Main(String[] args)
    {
        BusReservation obj = new BusReservation();
        obj.InitializeSeating();
        while (true)
        {
            Console.WriteLine("Choose : ");
            Console.WriteLine("1)Book Seat ");
            Console.WriteLine("2)Cancel Seat Reservation");
            Console.WriteLine("3)View Seating Arrangement");
            Console.WriteLine("4)Exit");
            int choice = int.Parse(Console.ReadLine()!);
            switch (choice)
            {
                case 1:
                    obj.BookSeat();
                    break;
                case 2:
                    obj.cancelSeat();
                    break;
                case 3:
                    obj.showSeats();
                    break;
                case 4:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Wrong Choice!!");
                    break;
            }
        }

    }
    public void InitializeSeating()
    {
        Console.WriteLine("Enter number of rows:");
        int numRows = int.Parse(Console.ReadLine()!);

        Seats = new int[numRows][];

        for (int i = 0; i < numRows; i++)
        {
            Console.WriteLine($"Enter number of seats for row {i + 1}:");
            int numSeats = int.Parse(Console.ReadLine()!);
            Seats[i] = new int[numSeats];

            // Initialize seats as available
            for (int j = 0; j < numSeats; j++)
            {
                Seats[i][j] = 0; // not booked
            }
        }
    }
    public void BookSeat()
    {
        // show the seating arrangement to the customer : 
        showSeats();
        Console.WriteLine("Enter the row no : ");
        int row = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter the Column no. : ");
        int col = int.Parse(Console.ReadLine()!);
        if (row >= 0 && row < Seats.Length &&
            col >= 0 && col < Seats[row].Length)
        {
            // for 1-based indexing
            Seats[row-1][col-1] = 1;    //             
            // show seating arrangement after booking
            showSeats();
        }
        else
        {
            Console.WriteLine("Invalid Row or Column!!");
            return;
        }

    }
    public void cancelSeat()
    {
        Console.WriteLine("Enter the row no : ");
        int row = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter the Column no. : ");
        int col = int.Parse(Console.ReadLine()!);
        if (row >= 0 && row < Seats.Length &&
           col >= 0 && col < Seats[row].Length)
        {
            if (Seats[row - 1][col - 1] == 1)
            {
                // for 1-based indexing
                Seats[row - 1][col - 1] = 0;
                Console.WriteLine("Seat Successfully Canceled!!");                                               
                showSeats();    // show seating arrangement after cancelling
            }
            else
            {
                Console.WriteLine("Seat is already vacant!!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid Row or Column!!");
            return;
        }
    }
    public void showSeats()
    {
        for (int i = 0; i < Seats.Length; i++)
        {
            Console.Write($"Row {i+1} : ");
            for (int j = 0; j < Seats[i].Length; j++)
            {
                Console.Write(Seats[i][j] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}

