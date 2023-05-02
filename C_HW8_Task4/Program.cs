// Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
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

int[,] FillSpiralMatrix(int n)
{
    int[,] matrix = new int[n, n];
    int value = 1;
    int row = 0;
    int col = 0;

    while (value <= n * n)
    {
        // заполнение верхней строки слева направо
        for (int i = col; i < n - col; i++)
        {
            matrix[row, i] = value;
            value++;
        }

        // заполнение правого столбца сверху вниз
        for (int i = row + 1; i < n - row; i++)
        {
            matrix[i, n - col - 1] = value;
            value++;
        }

        // заполнение нижней строки справа налево
        for (int i = n - col - 2; i >= col; i--)
        {
            matrix[n - row - 1, i] = value;
            value++;
        }

        // заполнение левого столбца снизу вверх
        for (int i = n - row - 2; i > row; i--)
        {
            matrix[i, col] = value;
            value++;
        }

        row++;
        col++;
    }

    return matrix;
}

int storonaKvadrata = ReadInt($"Введите значение стороны квадратной матрицы");
int[,] table = FillSpiralMatrix (storonaKvadrata);
Print2DArray(table);
System.Console.WriteLine();

