using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите неотрицательное число m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите неотрицательное число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        long result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m == 1)
            return n + 2;
        else if (m == 2)
            return 2 * n + 3;
        else if (m == 3)
            return (int)Math.Pow(2, n + 3) - 3;
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}