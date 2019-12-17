using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw02
{
    class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Pilkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub) : base(imie, nazwisko, dataUrodzenia)
        {
            this.pozycja = pozycja;
            this.klub = klub;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
             Console.WriteLine("Pozycja: " + pozycja);
            Console.WriteLine("Klub: " + klub);
            Console.WriteLine("Liczba goli: " + liczbaGoli);
        }  

        public virtual void StrzelGola()
        {
            liczbaGoli++;
        }

    }
}
