void Main()
{
    int m = ReadInt("Введите неотрицательное число M: ");
    int n = ReadInt("Введите неотрицательное число N: ");
    int result = A(m, n);
    Console.WriteLine($"Результат функции Аккермана A({m}, {n}) = {result}");
}

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return A(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return A(m - 1, A(m, n - 1));
    }
    else
    {
        throw new ArgumentException("Значения m и n должны быть неотрицательными");
    }
}

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
