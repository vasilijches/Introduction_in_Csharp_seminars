/*
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

// ПРЕОБРАЗОВАНИЕ ДВУМЕРНОГО МАССИВА В ОДНОМЕРНЫЙ ПО ЗАДАННОМУ ПРАВИЛУ
double[] MatrixToArray(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)]; // размер одномерного массива
                                                      // равен числу столбцов двумерного
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result += matrix[i, j];                   // сначала сложение с преобразованием
                                                      // в тип double
        }
        result = result / matrix.GetLength(0);        // потом деление числа с точкой на целое
        array[j] = result;
    }
    return array;
}

// ВЫВОД В ТЕРМИНАЛЕ ОДНОМЕРНОГО МАССИВА С ОКРУГЛЕНИЕМ
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(array[i], 1);
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write("; ");
        else Console.WriteLine(".");
    }
}

//========================================================================================

int[,] matrix2D1 = Create2DMatrixRndInt(3, 5, -9, 9);
Print2DMatrix(matrix2D1);

double[] array1 = MatrixToArray(matrix2D1);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(array1);