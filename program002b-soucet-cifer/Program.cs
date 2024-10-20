using System;

public class Program
{
    static void Main()


    {

        bool repeat = true;

        while (repeat)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("Zadejte celé číslo:");
            int digit = int.Parse(Console.ReadLine());
            int cislo = digit;
            Console.WriteLine("Součet cifer: " + SectiCifry(Math.Abs(digit)));
            Console.WriteLine("Soucin cifer: " + SoucinCifer(Math.Abs(digit)));

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            if (keyInfo.Key != ConsoleKey.C)
            {
                repeat = false;
            }
        }

    }

    public static int SectiCifry(int cislo)
    {
        if (cislo == 0)
            return 0; // Základní případ
        return (cislo % 10) + SectiCifry(cislo / 10); // Přičítání poslední cifry a rekurze
    }
    static int SoucinCifer(int cislo)
    {
        if (cislo == 0)
            return 1;  // Základní případ pro součin, pokud je číslo 0
        return (cislo % 10) * SoucinCifer(cislo / 10);
    }
}