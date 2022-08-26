using System;

namespace Evidence_pojištěných
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Database database = new();

            Console.WriteLine("--------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojistěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");

            char volba = '0';

            while(volba != '4')
            {
                switch (volba)
                {
                    case '1':
                        Console.WriteLine();
                        database.PridejUzivatele();
                        Console.WriteLine("\nData byla uložena.\n");
                        Console.WriteLine("Pokračujte libovolnou klávesou");
                        Console.ReadLine();
                        database.Menu();

                        break;

                    case '2':
                        Console.WriteLine();
                        database.VypisUzivatele();
                        Console.WriteLine();
                        Console.WriteLine("Pokračujte libovolnou klávesou");
                        Console.ReadLine();
                        database.Menu();

                        break;

                    case '3':
                        Console.WriteLine();
                        database.HledejUzivatele();
                        Console.WriteLine("\n");
                        Console.WriteLine("Pokračujte libovolnou klávesou");
                        Console.ReadLine();
                        database.Menu();

                        break;

                    case '4':
                        
                        Environment.Exit(0);
                        break;

                }

                volba = Console.ReadKey().KeyChar;
            }



            
        }
    }
}
