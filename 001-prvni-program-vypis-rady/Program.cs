using System;



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("First:");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Last:");
        int last = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Step:");
        int step = Convert.ToInt32(Console.ReadLine());

        int a = first;
        bool repeat = true;

        while (repeat == true)
        {
            Console.WriteLine("******************************************");

            while (a < last)

            {
                
                Console.WriteLine(a);
                a = a + step;

            }

            Console.WriteLine("Done!");
            Console.ReadKey();
            Console.WriteLine("Continue = Press C");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            if (keyInfo.Key != ConsoleKey.C)
            {
                repeat = false;
            }

        }
        Console.WriteLine("Konec ig");


    }
}