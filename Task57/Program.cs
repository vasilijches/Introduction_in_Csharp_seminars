/*
Составить частотный словарь элементов двумерного массива
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

// ПРЕОБРАЗОВАНИЕ ДВУМЕРНОГО МАССИВА В ОДНОМЕРНЫЙ
int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i + j * matrix.GetLength(1)] = matrix[i, j];
        }
    }

    return array;
}

// ВЫВОД ОДНОМЕРНОГО МАССИВА
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

// СОРТИРОВКА ЭЛЕМЕНТОВ ОДНОМЕРНОГО МАССИВА ПО ВОЗРАСТАНИЮ
void SortArray(int[] array)
{
    // for (int i = 0; i < array.Length - 1; i++)
    // {
    //     for (int j = i + 1; j < array.Length; j++)
    //     {
    //         if(array[j] < array[i])
    //         {
    //             int temp = array[i];
    //             array[i] = array[j];
    //             array[j] = temp;
    //         }
    //     }
    // }
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j + 1] < array[j])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

// ПРЕОБРАЗОВАНИЕ ОДНОМЕРНОГО МАССИВА В ЧАСТОТНЫЙ СЛОВАРЬ
void FrequencyDict(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        int count = 1;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] == array[i]) count++;
            else break;
        }

        string word = String.Empty;
        if (count % 10 >= 2 && count % 10 <= 4 && (count < 12 || count > 14)) word = "раза";
        else word = "раз";

        Console.WriteLine($"{array[i]} встречается {count} {word}");
        i += count;
    }
}

//==========================================================================

int[,] matrix2D1 = Create2DMatrixRndInt(3, 3, 1, 9);
Print2DMatrix(matrix2D1);
Console.WriteLine();

int[] array1 = MatrixToArray(matrix2D1);
PrintArray(array1);
Console.WriteLine();

SortArray(array1);
PrintArray(array1);
Console.WriteLine();

FrequencyDict(array1);