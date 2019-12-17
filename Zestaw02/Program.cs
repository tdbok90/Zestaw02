using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw02
{
    class Program
    {
        static void Main(string[] args)
        {
         
            ////////// Zadanie 1 ////////////
            Console.WriteLine("Zadanie 1");
            Osoba o = new Osoba("Adam", "Miś", "20.03.1980");
            Osoba o2 = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345);
            Osoba o3 = new Pilkarz("Mateusz", "Żbik", "10.08.1986", "obrońca", "FC Czestochowa");
            /*
            Console.WriteLine("\n");
            o.WypiszInfo();
            Console.WriteLine("\n");
            o2.WypiszInfo();
            Console.WriteLine("\n");
            o3.WypiszInfo();
            */
            Student s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
            Pilkarz p = new Pilkarz("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politehnika");
            /*
             Console.WriteLine("\n");
             s.WypiszInfo();
             Console.WriteLine("\n");
             p.WypiszInfo();

             ((Pilkarz)o3).StrzelGola();
             p.StrzelGola();
             p.StrzelGola();

             Console.WriteLine("\n");
             o3.WypiszInfo();
             Console.WriteLine("\n");
             p.WypiszInfo();

             Console.ReadKey();

             */
            /*
            ((Student)o2).DodajOcene("PO","20.02.2011", 5.0);
            ((Student)o2).DodajOcene("Bazy danych", "13.02.2011", 4.0);

            o2.WypiszInfo();

            s.DodajOcene("Bazy danych", "01.05.2011",5.0);
            s.DodajOcene("AWWW", "11.05.2011", 5.0);
            s.DodajOcene("AWWW", "02.04.2011", 4.5);

            s.WypiszInfo();

            s.DodajOcene("AWWW", "02.04.2011", 4.5);
            s.UsunOceny("AWWW");

            s.WypiszInfo();

            s.DodajOcene("AWW", "02.04.2011", 4.5);
            s.UsunOceny();

            s.WypiszInfo();
            */

            Pilkarz tadek = new PilkarzNozny("Tadek", "Bak", "07.03.1990", "napastnik", "FC Kabanosy");
            tadek.WypiszInfo();
            Console.WriteLine();
            tadek.StrzelGola();
            Console.WriteLine();
            tadek.WypiszInfo();

            Console.WriteLine();

            Pilkarz kamil = new PilkarzReczny("Kamil", "Bak", "21.12.1985", "obrońca", "Znicz Wareczka");
            kamil.WypiszInfo();
            Console.WriteLine();
            kamil.StrzelGola();
            Console.WriteLine();
            kamil.WypiszInfo();


            Console.ReadKey();




        }
    }
}
