// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
//          которая будет находить строку с наименьшей суммой элементов.

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArray(int cntRows, int cntColumns)
{
    int[,] array = new int[cntRows, cntColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 11);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


int FindRowWithMinSum(int[,] array)
{
    int minSum = int.MaxValue;
    int minIndex = -1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minIndex = i;
        }
    }

    return minIndex;
}


int cntRows = ReadInt($"Количество строк");
int cntColomns = ReadInt($"Количество колонок");
int[,] table = Generate2DArray(cntRows, cntColomns);
Print2DArray(table);
System.Console.WriteLine();
System.Console.WriteLine($"Строка с минимальной суммой элементов в ней это {FindRowWithMinSum(table)+1} строка.");

