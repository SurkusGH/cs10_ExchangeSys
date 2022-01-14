using System;
using System.Collections.Generic;

namespace cs10_paskaita_ExchangeSys
{
    class Program
    {
        public static List<string> Currency = new List<string> { "USD", "PLN", "BYR" };
        public static List<decimal> Value = new List<decimal> { 0.88m, 0.22m, 0.35m };
        static void Main(string[] args)

        /// Užduotis: Konvertuoti EUR į USD, PLN, BYR
        /// » Naudoti 2 masyvus
        /// » Su valiutų pavadinimais string
        /// » Su valiutų kursu(decimal[])
        {
            Meniu();
        }
        public static void Meniu()
        {
            while (true)                                    // <-- MAIN MENU - nesibaigiantis loop'as
            {
                Console.WriteLine($"Kiek pinigų kovertuojame? ");
                decimal input = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Galimos parinktys");
                Console.WriteLine("[1] EUR -> USD");
                Console.WriteLine("[2] EUR -> PLN");
                Console.WriteLine("[3] EUR -> BYR");

                int index = int.Parse(Console.ReadLine()); // <-- Index'as jungia switch ir nurodo listų index'ą
                switch (index)
                {
                    case 1:
                        Console.WriteLine("[1] EUR -> USD parinktis priimta.");
                        Parinktis(input, index);
                        break;
                    case 2:
                        Console.WriteLine("[2] EUR -> PLN parinktis priimta.");
                        Parinktis(input, index);
                        break;
                    case 3:
                        Console.WriteLine("[3] EUR -> BYR parinktis priimta.");
                        Parinktis(input, index);
                        break;
                }
            }
        }
        public static void Parinktis(decimal input, int index)
        {
            Console.WriteLine($"Konvertuojame {input}EUR į {Currency[index - 1]} kursu 1EUR = {Value[index - 1]}{Currency[index - 1]}");
            Console.WriteLine($"*Grąžinama suma {Math.Round(input / Value[index - 1]),2}{Currency[index - 1]}*");
        }
    }
}

