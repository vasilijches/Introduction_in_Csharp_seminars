/*
Задайте двумерный массив.
Напишите программу, которая
заменяет строки на столбцы.
В случае, если это не возможно,
программа должна вывестисообщение
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

//ТРАНСПОНИРОВАНИЕ КВАДРАТНОЙ МАТРИЦЫ (void method)
void SquareMatrixTransp(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

//ТРАНСПОНИРОВАНИЕ ПРОИЗВОЛЬНОЙ МАТРИЦЫ 
int[,] EveryMatrixTransp(int[,] matrix)
{
    int[,] resultMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resultMatrix[j, i] = matrix[i, j];
        }
    }
    return resultMatrix;
}

//==============================================================================

int[,] matrix2D1 = Create2DMatrixRndInt(3, 3, -9, 9);
Print2DMatrix(matrix2D1);

Console.WriteLine();

if (matrix2D1.GetLength(0) == matrix2D1.GetLength(1))
{
    SquareMatrixTransp(matrix2D1);
    Print2DMatrix(matrix2D1);
}
else Console.Write("Матрица не квадратная! Невозможно транспонировать!");

Console.WriteLine();

Print2DMatrix(EveryMatrixTransp(matrix2D1));