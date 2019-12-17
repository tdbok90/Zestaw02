using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw02
{
    class Ocena
    {
        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;


        public Ocena(string nazwaPrzedmiotu, string data, double wartosc)
        {
            this.nazwaPrzedmiotu = nazwaPrzedmiotu;
            this.data = data;
            this.wartosc = wartosc;
        }

        public string NazwaPrzedmiotu { get => nazwaPrzedmiotu; set => nazwaPrzedmiotu = value; }
        public string Data { get => data; set => data = value; }
        public double Wartosc { get => wartosc; set => wartosc = value; }

        public void WypiszInfo()
        {
            Console.WriteLine("Nazwa przedmiotu: " + nazwaPrzedmiotu);
            Console.WriteLine("Data: " + data);
            Console.WriteLine("Wartosc: " + wartosc);
        }

      
    }
}
