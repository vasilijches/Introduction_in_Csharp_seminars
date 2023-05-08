/*
Задайте двумерный массив.
Найдите элементы, у которых оба индекса чётные
и замените эти элементы на их квадраты
*/

int[,] Create2DMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random element = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = element.Next(min, max + 1);
        }
    }
    return matrix;
}

void Print2DMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
            if (j < matrix.GetLength(1)) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void MatrixEvenIndexChange(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix [i , j];
        }
    }
}

//----------------------------------------------------------------------------------------

int[,] matrix2D1 = Create2DMatrixRndInt(3, 4, -10, 10);
Print2DMatrix(matrix2D1);

Console.WriteLine();

MatrixEvenIndexChange(matrix2D1);
Print2DMatrix(matrix2D1);