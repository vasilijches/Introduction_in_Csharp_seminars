/*
Задайте двумерный массив из целых чисел.
Напишите программу, которая
удалит строку и столбец, на пересечении которых
расположен наименьший элемент массива
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

// ПОИСК НАИМЕНЬШЕГО ЭЛЕМЕНТА В МАССИВЕ И УДАЛЕНИЕ СООТВЕТСВУЮЩИХ СТРОКИ И СТОЛБЦА
int[,] MinElemCrossDelete(int[,] matrix)
{
    //Поиск наименьшего элемента
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
        }
    }

    // Создание уменьшенного двумерного массива
    int[,] cutMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    // Cоответствующее заполнение элементами уменьшенного массива
    for (int i = 0; i < cutMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < cutMatrix.GetLength(1); j++)
        {
            int k = (i < minI) ? 0 : 1;
            int l = (j < minJ) ? 0 : 1;
            cutMatrix[i, j] = matrix[i + k, j + l];            
        }
    }
    return cutMatrix;
}

//===================================================================

int[,] matrix2D1 = Create2DMatrixRndInt(3, 4, 1, 9);
Print2DMatrix(matrix2D1);
Console.WriteLine();

int[,] cutMatrix2D1 = MinElemCrossDelete(matrix2D1);
Print2DMatrix(cutMatrix2D1);