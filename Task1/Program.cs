void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: ");
    PrintNumber(M, N);
}

void PrintNumber(int M, int N)
{
    if (M > N)
    {
        return;
    }
    System.Console.Write(M + " ");
    PrintNumber(M + 1, N);
}

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main ();
