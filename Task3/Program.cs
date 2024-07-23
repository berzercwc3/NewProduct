void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize);
    
    System.Console.WriteLine("Оригинальный массив:");
    PrintArray(array);

    int[] reversedArray = ReverseArray(array, 0, arraySize - 1);
    
    System.Console.WriteLine("Реверсивный массив:");
    PrintArray(reversedArray);
}

int[] ReverseArray(int[] array, int start, int end)
{
    if (start >= end)
    {
        return array;
    }

    int temp = array[start];
    array[start] = array[end];
    array[end] = temp;

    return ReverseArray(array, start + 1, end - 1);
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
    System.Console.WriteLine();
}

int[] GenerateArray(int size)
{
    int[] tempArray = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rnd.Next(0, 10);
    }

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();


