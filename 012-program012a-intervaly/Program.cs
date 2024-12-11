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
            Console.Write("Zadejte početIntervalu ");
            int pocetint = int.Parse(Console.ReadLine());
           
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while (!int.TryParse(Console.ReadLine(), out dm))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while (!int.TryParse(Console.ReadLine(), out hm))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("==========================================");
            Console.WriteLine();

            //deklarace pole    
            int[] myArray = new int[n];

            Random randomNumber = new Random();

            int kladna = 0;
            int zaporna = 0;
            int nuly = 0;
            int suda = 0;
            int licha = 0;

            Console.WriteLine("\n\nNáhodná čísla:");
            for (int i = 0; i < n; i++)
            {
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.Write("{0}; ", myArray[i]);

                // if(myArray[i]>0)
                //     kladna++;
                // if(myArray[i]<0)
                //     zaporna++;
                // if(myArray[i]==0)
                //     nuly++;

                // kladná, záporná, nuly
                if (myArray[i] > 0)
                    kladna++;
                else if (myArray[i] < 0)
                    zaporna++;
                else
                    nuly++;

                // sudá, lichá
                if (myArray[i] % 2 == 0)
                    suda++;
                else
                    licha++;

            }

            


            int mezi = (hm - dm) / 4; ;
            int first = mezi;
            int second = mezi * 2;
            int third = mezi * 3;
            int fourth = mezi * 4;

            int pocet1 = 0;
            int pocet2 = 0;
            int pocet3 = 0;
            int pocet4 = 0;

            Console.WriteLine("\n <{0},{1}>  <{2},{3}> <{4},{5}>  <{6},{7}>", dm, first, first+1, second, second+1, third, third+1, fourth);


            foreach (int num in myArray)
            {
                if (num <= first)
                {
                    pocet1++;
                } else if (num <= second)
                    {
                        pocet2++;
                    }
                else if (num <= third)
                {
                    pocet3++;
                }
                else if (num <= fourth)
                {
                    pocet4++;
                }
            }
            double nominator = 1 / pocetint;

            // Výpočet šířky intervalu
            double sirka_intervalu = (double)(hm - dm) / pocetint;

            // Inicializace pole pro počty v intervalech
            int[] pocet_v_intervalech = new int[pocetint];

            // Rozdělení čísel do intervalů
            foreach (int cislo in myArray)
            {
                int index_intervalu = (int)((cislo - dm) / sirka_intervalu);
                pocet_v_intervalech[index_intervalu]++;
            }

            // Výpis výsledků
            for (int i = 0; i < pocetint; i++)
            {
                double dolni_mez = dm + i * sirka_intervalu;
                double horni_mez = dm + (i + 1) * sirka_intervalu;
                Console.WriteLine($"Interval <{dolni_mez}-{horni_mez}>: {pocet_v_intervalech[i]} čísel");

                }
            
            Console.WriteLine("\n <{0},{1}> = {2} ", dm, first, pocet1);





                Console.WriteLine("\n <{0},{1}> = {2} ", first + 1, second, pocet2);
                Console.WriteLine("\n <{0},{1}> = {2} ", second + 1, third, pocet3);
                Console.WriteLine("\n <{0},{1}> = {2} ", third + 1, fourth, pocet4);
           





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