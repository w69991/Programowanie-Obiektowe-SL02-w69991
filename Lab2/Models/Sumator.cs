using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }

        public int Suma()
        {
            return Liczby.Sum();
        }

        public float SumaPodziel3()
        {
            return Liczby.Sum() / 3;
        }

        public int IleElementow()
        {
            return Liczby.Length;
        }

        public void WypiszElementy()
        {
            foreach (var liczba in Liczby)
            {
                Console.WriteLine(liczba);
            }
        }

        public void Indexer(int lowIndex, int highIndex)
        {
            for (var i = lowIndex; i <= highIndex; i++)
            {
                Console.WriteLine(Liczby[i]);
            }
        }
    }
}
