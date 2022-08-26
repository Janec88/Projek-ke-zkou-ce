using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištěných
{
    internal class Pojistenci
    {
        private string jmeno;
        private string prijmeni;
        private string telCislo;
        private int vek;

        public Pojistenci(string jmeno, string prijmeni, string telCislo, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelCislo = telCislo;
            Vek = vek;

        }

        public string Jmeno { get; private set; }

        public string Prijmeni { get; private set; }

        public string TelCislo { get; private set; }

        public int Vek { get; private set; }

        public override string ToString()
        {
            return String.Format("{0} {1}, {2} telefon, let: {3}", Jmeno, Prijmeni, TelCislo, Vek);
        }

    }
}
