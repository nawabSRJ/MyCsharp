using System;

class TheaterSeating
{
    // Define jagged array to store seating arrangement
    public char[][] seatingArrangement;

    public static void Main(string[] args)
    {
        TheaterSeating theater = new TheaterSeating();
        theater.InitializeSeating();

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
                    theater.BookSeat();
                    break;
                case 2:
                    theater.CancelReservation();
                    break;
                case 3:
                    theater.DisplaySeatingArrangement();
                    break;
                case 4:
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Method to initialize seating arrangement
    public void InitializeSeating()
    {
        Console.WriteLine("Enter number of rows:");
        int numRows = int.Parse(Console.ReadLine()!);

        seatingArrangement = new char[numRows][];

        for (int i = 0; i < numRows; i++)
        {
            Console.WriteLine($"Enter number of seats for row {i + 1}:");
            int numSeats = int.Parse(Console.ReadLine()!);
            seatingArrangement[i] = new char[numSeats];

            // Initialize seats as available
            for (int j = 0; j < numSeats; j++)
            {
                seatingArrangement[i][j] = 'A'; // 'A' stands for available
            }
        }
    }

    // Method to book a seat
    public void BookSeat()
    {
        Console.WriteLine("Enter row number to book (1-based index):");
        int row = int.Parse(Console.ReadLine()!) - 1;

        Console.WriteLine("Enter seat number to book (1-based index):");
        int seat = int.Parse(Console.ReadLine()!) - 1;

        if (row >= 0 && row < seatingArrangement.Length &&
            seat >= 0 && seat < seatingArrangement[row].Length)
        {
            if (seatingArrangement[row][seat] == 'A')
            {
                seatingArrangement[row][seat] = 'B'; // 'B' stands for booked
                Console.WriteLine("Seat booked successfully.");
            }
            else
            {
                Console.WriteLine("Seat is already booked.");
            }
        }
        else
        {
            Console.WriteLine("Invalid row or seat number.");
        }
    }

    // Method to cancel a reservation
    public void CancelReservation()
    {
        Console.WriteLine("Enter row number to cancel (1-based index):");
        int row = int.Parse(Console.ReadLine()!) - 1;

        Console.WriteLine("Enter seat number to cancel (1-based index):");
        int seat = int.Parse(Console.ReadLine()!) - 1;

        if (row >= 0 && row < seatingArrangement.Length &&
            seat >= 0 && seat < seatingArrangement[row].Length)
        {
            if (seatingArrangement[row][seat] == 'B')
            {
                seatingArrangement[row][seat] = 'A'; // 'A' stands for available
                Console.WriteLine("Reservation canceled successfully.");
            }
            else
            {
                Console.WriteLine("Seat was not booked.");
            }
        }
        else
        {
            Console.WriteLine("Invalid row or seat number.");
        }
    }

    // Method to display the seating arrangement
    public void DisplaySeatingArrangement()
    {
        Console.WriteLine("Current seating arrangement:");
        for (int i = 0; i < seatingArrangement.Length; i++)
        {
            Console.Write("Row " + (i + 1) + ": ");
            for (int j = 0; j < seatingArrangement[i].Length; j++)
            {
                Console.Write(seatingArrangement[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
