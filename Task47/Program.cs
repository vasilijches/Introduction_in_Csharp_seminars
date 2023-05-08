/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

//СОЗДАНИЕ ДВУМЕРНОЙ МАТРИЦЫ СО СЛУЧАЙНЫМИ ВЕЩЕСТВЕННЫМИ ЧИСЛАМИ
double[,] Create2DMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random element = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = element.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

//ВЫВОД В ТЕРМИНАЛЕ ДВУМЕРНОЙ МАТРИЦЫ ВЕЩЕСТВЕННЫХ ЧИСЕЛ С ОКРУГЛЕНИЕМ
void Print2DMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(matrix[i, j], 1); //округление
            Console.Write($"{matrix[i, j], 5}");
            if (j < matrix.GetLength(1)) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

//========================================================================================

double[,] matrix2D1 = Create2DMatrixRndInt(3, 4, -9, 9);
Print2DMatrix(matrix2D1);