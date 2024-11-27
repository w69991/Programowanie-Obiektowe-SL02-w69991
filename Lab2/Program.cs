using Lab2.Models;

//zad 1
var osoba = new Osoba("Jan", "Kowalski", 40, "12312312312");
Console.WriteLine(osoba.PrzedstawSie());
osoba.UstawWiek(-3);
Console.WriteLine(osoba.Wiek);

//zad 2
var licz = new Licz(6);
licz.Dodaj(10);
licz.Stan();
licz.Odejmij(2);
licz.Stan();

//zad 3
var sumator = new Sumator([2, 4, 6, 8, 10]);
sumator.WypiszElementy();
Console.WriteLine(sumator.Suma());
Console.WriteLine(sumator.SumaPodziel3());
Console.WriteLine(sumator.IleElementow());
sumator.Indexer(0, 3);