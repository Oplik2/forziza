using System;
using System.IO.IsolatedStorage;
using static System.Runtime.InteropServices.JavaScript.JSType;
internal class Program
{
    private static void Main(string[] args)
    {
        bool repeat = true;
        int a = 0;
        int b = 0;
        while (repeat)
        {

            Console.Clear();
            razitko();
            ulong a = nacistcislo("Zadejte Cislo a:");
            ulong b = nacistcislo("Zadejte Cislo a:");










            Console.WriteLine("Zadej C pro opakovani");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            if (keyInfo.Key != ConsoleKey.C)
            {
                repeat = false;
            }
        }
        static void razitko()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue
;
        }
        
        
        Console.WriteLine("Konec");

        static ulong nacistcislo(string zprava)
        {
            Console.Write(zprava);
            ulong cislo;
            while (!ulong.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("nebylo zadano cislo");
            }
            return cislo;
        }
        static ulong calcNSD(ulong a, ulong b)
        {

            return 1;
        }

    }
}