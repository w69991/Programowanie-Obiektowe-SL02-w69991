public static class Lab1
{
    public static void Zad1()
    {
        Console.Write("Podaj liczbe:");
        var input = Console.ReadLine();
        var liczba = int.Parse(input);

        if (liczba % 2 == 0)
        {
            Console.WriteLine("Liczba jest parzysta");
        }
        else if (liczba % 2 == 1)
        {
            Console.WriteLine("Liczba jest nieparzysta");
        }
        else
        {
            Console.WriteLine("Liczba nie jest ani parzysta ani nieparzysta");
        }
    }

    public static void Zad2()
    {
        Console.Write("Podaj liczbe:");
        var input = Console.ReadLine();
        var liczba = int.Parse(input);

        for (var i = 1; i <= liczba; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static int Zad4(int n)
    {
        if (n is 0 or 1)
            return 1;
                
        return Zad4(n - 1) * n;
    }

    public static void Zad5()
    {
        var random = new Random();
        var rngLiczba = random.Next(1, 100);
        var proba = 0;

        Console.WriteLine("Zgadnij liczbe z zakresu 1-100");
        while (true)
        {
            proba++;
            Console.Write("Podaj liczbe:");
            var input = Console.ReadLine();
            var liczba = int.Parse(input);

            if (liczba == rngLiczba)
            {
                Console.WriteLine($"Gratulacje! Zgadles liczbe! {proba} prob");
                break;
            }

            Console.WriteLine(liczba < rngLiczba ? "Za mala liczba" : "Za duza liczba");
        }
    }

    public static void Zad3()
    {
        while (true)
        {
            Console.WriteLine("0. koniec programu");
            Console.WriteLine("1. zadanie 4");
            Console.WriteLine("2. zadanie 5");
            Console.WriteLine("3. cos tam");
            Console.Write("Podaj liczbe:");
            var input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    break;

                case "1":
                    Console.WriteLine("Wpisz swoją liczbe: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Silnia wynosi: {Zad4(n)} ");
                    break;

                case "2":
                    Zad5();
                    break;

                case "3":
                    Console.WriteLine("cos tam 3");
                    break;
            }
        }
    }
}