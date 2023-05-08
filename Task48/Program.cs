/*
Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле Amn = m + n.
Выведите полученный массив на экран
*/

int[,] Create2DMatrixRndInt(int rows, int columns)
{
    int[,] matrix2D = new int[rows, columns];
    
    for (int i = 0; i < matrix2D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2D.GetLength(1); j++)
        {
            matrix2D[i, j] = i + j;
        }
    }
    return matrix2D;
}

void Print2DMatrix (int[,] matrix2D)
{
    for (int i = 0; i < matrix2D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2D.GetLength(1); j++)
        {
            Console.Write($"{matrix2D[i, j], 5}");
            if (j < matrix2D.GetLength(1)) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

//------------------------------------------------------------------------------

int[,] matrix2D1 = Create2DMatrixRndInt(10, 17);
Print2DMatrix(matrix2D1);