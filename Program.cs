using System;

class Program
{
    static void Main()
    {
        int n = GetNumber("Podaj liczbę n: ");

        Console.WriteLine($"Pary liczb naturalnych o sumie {n}:");
        PrintNumberPairs(n);

        Console.ReadKey();
    }

    static void PrintNumberPairs(int n)
    {
        for (int i = 1; i <= n / 2; i++)
        {
            int j = n - i;
            Console.WriteLine($"{i}, {j}");
        }
    }

    static int GetNumber(string message)
    {
        int number;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out number) && number >= 0)
            {
                break;
            }
            Console.WriteLine("Błędne dane. Podaj liczbę naturalną.");
        }

        return number;
    }
}

