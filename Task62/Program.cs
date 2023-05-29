/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


// СПИРАЛЬНОЕ ЗАПОЛНЕНИЕ МАССИВА
void FillMatrix(int[,] matrix)
{
    int number = 1;
    int i = 0, j = 0, k = 0;

    while (number <= matrix.Length)
    {
        matrix[i, j] = number;

        //проход по верхнему краю справа налево
        if (i == k && j < matrix.GetLength(1) - 1 - k) j++; 
        //поворот в правом верхнем углу
        else if (i == k && j == matrix.GetLength(1) - 1 - k) i++; 
        
        //проход по правому краю сверху вниз
        else if (i < matrix.GetLength(0) - 1 - k  && j == matrix.GetLength(1) - 1 - k) i++;
        //поворот в правом нижнем углу
        else if (i == matrix.GetLength(0) - 1 - k && j == matrix.GetLength(1) - 1 - k) j--;

        //проход по нижнему краю
        else if (i == matrix.GetLength(0) - 1 - k && j > k ) j--;
        //поворот в левом нижнем углу
        else if (i == matrix.GetLength(0) - 1 - k && j == k) i--;

        //проход по левому краю
        else if (i > k + 1 && j == k) i--;
        //поворот в левом верхнем углу
        else if (i == k + 1 && j == k) {j++; k++;}
        
        number++;        
    }
}

// ВЫВОД ДВУМЕРНОГО МАССИВА В ТЕРМИНАЛЕ
void Print2DMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string element = matrix[i, j] < 10
                                                ? $"0{matrix[i, j]}"
                                                : $"{matrix[i, j]}";
            Console.Write($"{element,5}");
            if (j < matrix.GetLength(1) - 1) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

//===================================================================
Console.Clear();

Random size = new Random();
int[,] matrix1 = new int[size.Next(1, 10), size.Next(1, 10)];

FillMatrix(matrix1);
Print2DMatrix(matrix1);