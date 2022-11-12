// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int num)
{
    var matrix = new int[rows, columns, depth];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = rnd.Next(num + 1);
            }
            
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
            if (i < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, z], 3}, ");
            else Console.Write($"{matrix[i, j, z ], 3}. ");
            }
        }
        Console.WriteLine("|");
    }
}

int[,,] array3D = CreateMatrixRndInt(2, 2, 2, 10);
PrintMatrix(array3D);