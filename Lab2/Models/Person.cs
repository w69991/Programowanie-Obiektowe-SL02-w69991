using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Osoba
    {
        private string Imie;
        private string Nazwisko;
        private int Wiek;
        private string Pesel;
            
        public Osoba(string imie, string nazwisko, int wiek, string pesel)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Pesel = pesel;
        }
    public string imie
        { get { return Imie; }
          set { Imie = value; }
        }
    public string nazwisko
            { get { return Nazwisko; } set { Nazwisko = value; } }
    public int wiek
            { get { return Wiek; } set { Wiek = value; } }

     public readonly string pesel;
    
    public void PrzedstawSie()
        {
            Console.WriteLine($"Nazywam sie {imie} {nazwisko} i mam {wiek} lat ");
        }
    }
}
