using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());
        
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        if (M < 1 || N < 1 || M > N)
        {
            Console.WriteLine("Введите корректные значения M и N (M <= N и M, N >= 1).");
            return;
        }

        Console.WriteLine($"Числа от {M} до {N}:");
        PrintNumbers(M, N);
    }

    static void PrintNumbers(int current, int N)
    {
        if (current > N)
            return;

        Console.Write(current + " ");
        PrintNumbers(current + 1, N);
    }
}