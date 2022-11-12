// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);

int [,] OtherMatrixRows(int[,] matrix1)
{
  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
      for (int k = 0; k < matrix1.GetLength(1) - 1; k++)
      {
        if (matrix1[i, k] < matrix1[i, k + 1])
        {
          int temp = matrix1[i, k + 1];
          matrix1[i, k + 1] = matrix1[i, k];
          matrix1[i, k] = temp;
        }
      }
    }
  }
  return matrix1;
}

void PrintSortMatrixLines(int[,] matrix)
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

Console.WriteLine();
int [,] newArray = OtherMatrixRows(array2D);
PrintSortMatrixLines(newArray);