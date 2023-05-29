/*
Сформируйте трёхмерный массив
из неповторяющихся двузначных чисел.
Напишите программу, которая 
будет построчно выводить массив, 
добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/

//ЗАДАНИЕ ТРЁХМЕРНО МАССИВА СЛУЧАЙНОГО РАЗМЕРА С НЕПОВТОРЯЮЩИМИСЯ ДВУХЗНАЧНЫМИ ЧИСЛАМИ
int[,,] CreateRandomSize3DMatrix(int maxSize, int min, int max)
{
    Random length = new Random();

    int length1 = length.Next(2, maxSize + 1);
    int length2 = length.Next(2, maxSize + 1);
    int length3 = length.Next(2, maxSize + 1);

    int[,,] matrix = new int[length1, length2, length3];

    int count = 10;
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            for (int k = 0; k < length3; k++)
            {
                matrix[i, j, k] += count;
                count++;
            }
        }
    }
    return matrix;
}

// ВЫВОД ДВУМЕРНОГО МАССИВА В ТЕРМИНАЛЕ
void Print3DMatrix(int[,,] matrix)
{
    Console.Write("Размер 3D массива: ");
    Console.Write(matrix.GetLength(0));
    Console.Write(" x ");
    Console.Write(matrix.GetLength(1));
    Console.Write(" x ");
    Console.WriteLine(matrix.GetLength(2));
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                string element = $"{matrix[i, j, k]}({i}, {j}, {k})";
                Console.Write($"{element,15}");
            }
        }
        Console.WriteLine();
    }
}

//=========================================================================
Console.Clear();

int[,,] matrix3D1 = CreateRandomSize3DMatrix(3, 1, 9);
Print3DMatrix(matrix3D1);
Console.WriteLine();