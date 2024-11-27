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
        private string imie;
        private string nazwisko;
        private int wiek;
        private string pesel;
            
        public Osoba(string imie, string nazwisko, int wiek, string pesel)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
            this.pesel = pesel;
        }
    public string Imie
        { get { return imie; }
          set { imie = value; }
        }
    public string Nazwisko
        {
            get { return nazwisko; } 
            set { nazwisko = value; } 
        }

        public int Wiek
        {
            get { return wiek; } 
            set { wiek = value; }
        }

        public string Pesel
        {
            get { return pesel; }
        }
     
     public string PrzedstawSie()
     {
         return $"Nazywam sie {imie} {nazwisko} i mam {wiek} lat ";
     }

     public void UstawWiek(int setwiek)
     {
         if (setwiek < 0)
         {
             Wiek = 0;
             return;
         }

         Wiek = setwiek;
     }
     
    }
}
