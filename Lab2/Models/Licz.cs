using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Licz
    {
        private int Wartosc { get; set; }

        public Licz(int wartosc)
        {
            Wartosc = wartosc;
        }
        
        public void Dodaj(int parametr)
        {
            Wartosc += parametr;
        }

        public void Odejmij(int parametr)
        {
            Wartosc -= parametr;
        }

        public void Stan()
        {
            Console.WriteLine($"Stan obiektu: {Wartosc}");
        }
    }


}
