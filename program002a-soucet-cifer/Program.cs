using System;

class Program
{
    static void Main()
    { 
        bool repeat = true;
       
        while (repeat)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("Zadejte celé číslo:");
            int cislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Součet cifer: " + SectiCifry(cislo));

            Console.WriteLine("C to continue");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            if (keyInfo.Key != ConsoleKey.C)
            {
                repeat = false;
            }
        }
        Console.WriteLine("Konec");
    }
   
   
       static int SectiCifry(int cislo)
    {
        cislo = Math.Abs(cislo); // Pro práci jen s kladnými čísly
        int soucet = 0;

        while (cislo > 0)
        {
            soucet += cislo % 10; // Přičítání poslední cifry
            cislo /= 10;          // Odstranění poslední cifry
        }

        return soucet;
    }
    
}