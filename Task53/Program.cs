/*
Задайте двумерный массив.
Напишите программу, которая
поменяет местами первую и последнюю строку массива
*/

// ЗАДАНИЕ ДВУМЕРНОГО МАССИВА ИЗ СЛУЧАЙНЫХ ЦЕЛЫХ ЧИСЕЛ
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

// ВЫВОД В ТЕРМИНАЛЕ ДВУМЕРНОГО МАССИВА
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

// ПЕРЕМЕНА МЕСТ МЕЖДУ ПЕРВОЙ И ПОСЛЕДНЕЙ СТРОКОЙ
void FirstLastRowsReplace (int[,] matrix)
{
    int temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) -1 , j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}

//=========================================================================

int[,] matrix2D1 = Create2DMatrixRndInt(3, 5, -9, 9);
Print2DMatrix(matrix2D1);

Console.WriteLine();

FirstLastRowsReplace(matrix2D1);
Print2DMatrix(matrix2D1);