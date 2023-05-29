/*
Задайте двумерный массив.
Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
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
            if (j < matrix.GetLength(1) - 1) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

// УПОРЯДОЧИВАНИЕ ОДНОЙ СТРОКИ ДВУМЕРНОГО МАССИВА ПО УБЫВАНИЮ
void DescendingRowSort(int[,] matrix, int rowIndex)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[rowIndex, j + 1] > matrix[rowIndex, j])
            {
                int temp = matrix[rowIndex, j];
                matrix[rowIndex, j] = matrix[rowIndex, j + 1];
                matrix[rowIndex, j + 1] = temp;
            }
        }
    }
}

// УПОРЯДОЧИВАНИЕ ВСЕХ СТРОК ДВУМЕРНОГО МАССИВА ПОСТРОЧНО ПО УБЫВАНИЮ
void DescendingMatrixSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        DescendingRowSort(matrix, i);
    }
}

//===============================================================

int[,] matrix2D1 = Create2DMatrixRndInt(5, 3, -9, 9);
Print2DMatrix(matrix2D1);
Console.WriteLine();

DescendingMatrixSort(matrix2D1);
Print2DMatrix(matrix2D1);