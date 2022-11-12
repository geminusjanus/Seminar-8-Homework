// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateFirstMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintFirstMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}, ");
        }
        Console.WriteLine("|");
    }
}

int[,] CreateSecondMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix1 = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix1;
}

void PrintSecondMatrix(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (i < matrix1.GetLength(1) - 1) Console.Write($"{matrix1[i, j],3}, ");
            else Console.Write($"{matrix1[i, j],3}, ");
        }
        Console.WriteLine("|");
    }
}

int[,] MultiplyMatrix(int[,] matrix, int[,] matrix2)
{
    if (matrix.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Матрицы нельзя перемножить");
    int[,] r = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                r[i, j] += matrix[i, k] * matrix2[k, j];
            }
        }
    }
    return r;
}
void PrintMultiplyMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] array2D = CreateFirstMatrixRndInt(2, 2, 1, 10);
PrintFirstMatrix(array2D);
Console.WriteLine();
int[,] array12D = CreateSecondMatrixRndInt(2, 2, 1, 10);
PrintSecondMatrix(array12D);
Console.WriteLine();
int[,] multiplyMatrix = MultiplyMatrix(array2D, array12D);
PrintMultiplyMatrix(multiplyMatrix);