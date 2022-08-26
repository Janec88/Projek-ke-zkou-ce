using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištěných
{
    internal class Database
    {
        private List<Pojistenci> list;

        public Database()
        {

            list = new List<Pojistenci>();
        }

        
        public void PridejUzivatele()
        {
            Console.Write("Zadejte jméno pojištěného: ");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Nesprávné zadání. Zadejte prosím znovu:");
            }

            Console.Write("Zadejte příjmení: ");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Nesprávné zadání. Zadejte prosím znovu:");
            }


            Console.Write("Zadejte telefonní číslo: ");
            string telCislo;
            while (string.IsNullOrWhiteSpace(telCislo = Console.ReadLine()) | (telCislo.Length < 13))
            {
                Console.WriteLine("Nesprávné zadání. Zadejte prosím znovu ve formátu +420xxxxxxxxx:");
            }

            Console.Write("Zadejte věk: ");
            int vek;
            while ((!int.TryParse(Console.ReadLine(), out vek)) | ((vek > 100) | (vek <= 0)))
            {
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");

            }


            list.Add(new Pojistenci(jmeno, prijmeni, telCislo, vek));
        }

        
        public void VypisUzivatele()
        {
            int pocet = 0;
            foreach (var uzivatele in list)
            {
                pocet++;

            }
            if (pocet == 0)
                Console.WriteLine("Neexistují žádné pojištěné osoby. ");
            else
                Console.WriteLine("Jsou evidovány tyto osoby: ");
            Console.WriteLine();
            foreach (var uzivatele in list)
            {

                Console.WriteLine(uzivatele);
            }

        }


        public void HledejUzivatele()
        {
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string hledaneJmeno = Console.ReadLine().ToLower();

            Console.WriteLine("Zadejte příjmení pojištěného: ");
            string hledanePrijmeni = Console.ReadLine().ToLower();

            foreach (var item in list)
            {

                if ((item.Jmeno.ToLower() == hledaneJmeno && item.Prijmeni.ToLower() == hledanePrijmeni)
                    || (item.Jmeno.ToUpper() == hledaneJmeno && item.Prijmeni.ToUpper() == hledanePrijmeni))
                {
                    Console.WriteLine();
                    Console.WriteLine(item);
                    return;
                }
            }



            Console.WriteLine("Nenalezen žádný pojištěnec");




        }


        public void Menu()
        {
            Console.WriteLine("Vyberte si akci: ");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Ukončit program");
        }

    }
}
