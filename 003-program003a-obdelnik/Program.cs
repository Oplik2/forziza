using System;
using System.IO.IsolatedStorage;
using System.Reflection.PortableExecutable;



internal class Program
{
    private static void Main(string[] args)
    {
        bool repeat = true;
        int a = 0;
        int b = 0;
        while (repeat)
        {
            Console.WriteLine("******************************************");


            Console.WriteLine("Zadej A = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej B = ");
            b = int.Parse(Console.ReadLine());



            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("*");
                }
            Console.WriteLine();
            }






                ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            if (keyInfo.Key != ConsoleKey.C)
            {
                repeat = false;
            }
        }
        Console.WriteLine("Konec"); 
        Console.WriteLine("Soucet " +  );
    }

   
    
}