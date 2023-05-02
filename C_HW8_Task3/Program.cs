// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Произведение матриц вычисляются следующим образом:

// |1   2   3|       |7   8  |       |58  64  |
// |         |       |       |       |        |
// |4   5   6|   *   |9   10 |    =  |139 154 |
//                   |       |
//                   |11  12 |


// c11 = a11 · b11 + a12 · b21 + a13 · b31 = 1 · 7 + 2 · 9 + 3 · 11 = 7 + 18 + 33 = 58

// c12 = a11 · b12 + a12 · b22 + a13 · b32 = 1 · 8 + 2 · 10 + 3 · 12 = 8 + 20 + 36 = 64

// c21 = a21 · b11 + a22 · b21 + a23 · b31 = 4 · 7 + 5 · 9 + 6 · 11 = 28 + 45 + 66 = 139

// c22 = a21 · b12 + a22 · b22 + a23 · b32 = 4 · 8 + 5 · 10 + 6 · 12 = 32 + 50 + 72 = 154


int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArrayMatrix(int cntRows, int cntColumns)
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

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{

    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);

    int[,] result = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            int sum = 0;
            for (int k = 0; k < cols1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}


int cntRows1 = ReadInt($"Количество строк 1 матрицы");
int cntColomns1 = ReadInt($"Количество колонок 1 матрицы");
int cntRows2 = ReadInt($"Количество строк 2 матрицы");
int cntColomns2 = ReadInt($"Количество колонок 2 матрицы");


int[,] matrix1 = Generate2DArrayMatrix(cntRows1, cntColomns1);
int[,] matrix2 = Generate2DArrayMatrix(cntRows2, cntColomns2);


Print2DArray(matrix1);
System.Console.WriteLine();
Print2DArray(matrix2);
System.Console.WriteLine();

if (cntColomns1 == cntRows2)
{
    Print2DArray(MultiplyMatrices(matrix1, matrix2));
}
else
{
    System.Console.WriteLine("Матрицы не комплиментарны");
}


