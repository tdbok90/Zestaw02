using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw02
{
     class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;
        private List<Ocena> oceny = new List<Ocena>();

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrIndeksu ) : base(imie,nazwisko, dataUrodzenia)
        {
            this.rok = rok;
            this.grupa = grupa;
            this.nrIndeksu = nrIndeksu;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rok: " + rok);
            Console.WriteLine("Grupa: " + grupa);
            Console.WriteLine("Numer Indeksu: " + nrIndeksu);
            WypiszOceny();
        }

        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            Ocena ocena = new Ocena(nazwaPrzedmiotu, data, wartosc );
            oceny.Add(ocena);
        }

        public void WypiszOceny()
        {
            foreach (Ocena ocena in oceny)
            {
                Console.WriteLine(ocena.Wartosc);
            }
        }

        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            foreach (Ocena ocena in oceny)
            {
                if (ocena.NazwaPrzedmiotu.Equals(nazwaPrzedmiotu))
                {
                    Console.WriteLine(ocena.Wartosc + " ");
                }
            }

        }
        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
            {
            foreach (Ocena ocena in oceny)
            {
                if (ocena.NazwaPrzedmiotu.Equals(nazwaPrzedmiotu) && ocena.Data.Equals(data) && ocena.Wartosc.Equals(wartosc))
                {
                    oceny.Remove(ocena);
                }
            }

        }
        public void UsunOceny( )
        {
            oceny.Clear();
        }

        public void UsunOceny(string nazwaPrzedmiotu)
        {
           
            for (int i=0;i<oceny.Count;)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu.Equals(nazwaPrzedmiotu))
                {
                    oceny.Remove(o);
                }
                else
                {
                    ++i;
                }
            }
        }

    }
}
