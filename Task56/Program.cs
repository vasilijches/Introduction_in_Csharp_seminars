/*
Задайте двумерный массив.
Напишите программу, которая
будет находить строку с наименьшей суммой элементов.
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

// CУММИРОВАНИЕ ЭЛЕМЕНТОВ ОДНОЙ СТРОКИ ДВУМЕРНОГО МАССИВА
int MatrixRowSum(int[,] matrix, int rowIndex)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum += matrix[rowIndex, i];
    }
    return sum;
}

// НАХОЖДЕНИЕ СТРОКИ ДВУМЕРНОГО МАССИВА С МИНИМАЛЬНОЙ СУММОЙ
int MatrixMinSumRowNumber(int[,] matrix)
{
    int sum = 0;
    int minSum = MatrixRowSum(matrix, 0); 
    int minSumRowNumber = 1;

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        sum = MatrixRowSum(matrix, i);
        
        if (sum < minSum)
        {
            minSum = sum;            
            minSumRowNumber += i;            
        }
    }
    return minSumRowNumber;
}

//========================================================================

int[,] matrix2D1 = Create2DMatrixRndInt(5, 3, 1, 9);
Print2DMatrix(matrix2D1);
Console.WriteLine();

int minSumRowNumber1 = MatrixMinSumRowNumber(matrix2D1);
Console.WriteLine($"Сумма элементов в строке №{minSumRowNumber1} минимальна");
Console.WriteLine();