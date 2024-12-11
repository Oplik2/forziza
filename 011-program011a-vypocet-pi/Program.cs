using System;
using System.IO.IsolatedStorage;



internal class Program
{
    private static void Main(string[] args)
    {
        bool repeat = true;
        int a = 0;
        int b = 0;
        while (repeat)
        {


            Console.WriteLine("Zadejte pocet cleny rady");

            double precision = double.Parse(Console.ReadLine());
            //int precision = 1000000; // Počet členů řady
            double pi = 0;
            int sign = 1;

            for (int i = 1; i <= precision; i += 2)
            {
                pi += sign * (1.0 / i);
                sign *= -1;
            }

            pi *= 4;

            Console.WriteLine("Vypočítaná hodnota π: " + pi);

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            if (keyInfo.Key != ConsoleKey.C)
            {
                repeat = false;
            }
        }
        Console.WriteLine("Konec");
    }
}