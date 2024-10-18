class ZoneSales
{
    public int[][] SalesChart;
    public int[] ranks = new int[4];
    public static void Main(String[] args)
    {
        ZoneSales obj = new ZoneSales();
        obj.Initialize();
        obj.printSalesChart();
        obj.inputSalesData();
        obj.printSalesChart();
        obj.rankSales();
        // Console.WriteLine("Choose : ");
    }
    public void Initialize()
    {
        SalesChart = new int[4][]; // 4 Zones  :  rows
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 12; j++)    // 12 Months : cols
            {
                SalesChart[i] = new int[12];
            }
        }
    }
    void printSalesChart()
    {
        for (int i = 0; i < SalesChart.Length; i++)
        {
            Console.Write($"Zone {i} : ");
            for (int j = 0; j < 12; j++)    // 12 Months : cols
            {
                Console.Write(SalesChart[i][j] + " ");
            }
            Console.WriteLine("\n");
        }
    }
    void inputSalesData()
    {
        for (int i = 0; i < SalesChart.Length; i++)
        {
            Console.Write($"Zone {i} : ");
            for (int j = 0; j < 12; j++)    // 12 Months : cols
            {
                SalesChart[i][j] = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("\n");
        }
    }

    void rankSales()
    {
        for (int i = 0; i < SalesChart.Length; i++)
        {
            int zoneEarnings = 0;
            for (int j = 0; j < 12; j++)
            {
                zoneEarnings += SalesChart[i][j];
            }
            ranks[i] = zoneEarnings;
        }

        // Create an array of zone indices for sorting
        int[] sortedZones = { 0, 1, 2, 3 };

        // Sort based on earnings (ranks)
        Array.Sort(ranks, sortedZones);
        Array.Reverse(sortedZones);  // To get in descending order

        Console.WriteLine("The Scores (from highest to lowest) are: ");
        for (int i = 0; i < sortedZones.Length; i++)
        {
            int zoneIndex = sortedZones[i];
            Console.Write($"Zone {zoneIndex} : ");
            Console.Write(ranks[zoneIndex]);
            Console.WriteLine("\n");
        }
    }
}
