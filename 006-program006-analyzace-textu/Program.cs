using System;

class Program
{
    static void Main()

    {
        bool repeat = true;
        while (repeat)  
        Console.WriteLine("Analyza textu");
        int sa = 0;
        int so = 0;
        int os = 0;

        Console.WriteLine("\n\nZadej retezec:");
        Console.WriteLine();
        string mytext = Console.ReadLine();



            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            if (keyInfo.Key != ConsoleKey.C)
            {
                repeat = false;
            }  
        Console.WriteLine("Konec");
    }
     

}
