// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

void PrintMatrix(int[,] matrix)
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


int SumRows(int[,] matrix, int i)
{
    int sumRows = matrix[i, 0];

    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumRows += matrix[i, j];
    }
    return sumRows;
}
int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
int sumRows = SumRows(array2D, 0);
PrintMatrix(array2D);

int minSumRow = 0;
for (int i = 1; i < array2D.GetLength(0); i++)
{
    int tempMinRow = SumRows(array2D, i);
    if (sumRows > tempMinRow)
    {
        sumRows = tempMinRow;
        minSumRow = i;
    }
}
Console.WriteLine($"\n{minSumRow + 1} - строкa с наименьшей суммой элементов ");
