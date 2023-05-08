/*
Задайте двумерный массив.
Найдите сумму элементов, находящихся на главной диагонали
(с индексами (0;0), (1;1) и т.д.)
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
            if (j < matrix.GetLength(1) - 1) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[] ArrayFromMatrixMainDiagonalNumbers(int[,] matrix)
{
    int stopNumber = matrix.GetLength(0) < matrix.GetLength(1)
                                                            ? matrix.GetLength(0)
                                                            : matrix.GetLength(1);
    int[] array = new int[stopNumber];

    for (int i = 0; i < stopNumber; i++)
    {
        array[i] = matrix[i, i];
    }
    return array;
}

void PrintArrayToSumFormula(int[] array)
{
    Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] >= 0) Console.Write("+");
        Console.Write(array[i]);        
    }
    Console.Write(" = ");
}

int ArraySum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}
//=========================================================================================

int[,] matrix2D1 = Create2DMatrixRndInt(5, 6, -9, 9);
Print2DMatrix(matrix2D1);

int[] array1 = ArrayFromMatrixMainDiagonalNumbers(matrix2D1);
int arraySum1 = ArraySum(array1);

Console.Write($"Сумма элементов на главной диагонали: ");
PrintArrayToSumFormula(array1);
Console.WriteLine(arraySum1);