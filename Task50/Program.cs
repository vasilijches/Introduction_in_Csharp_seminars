/*
Задача 50. Напишите программу, которая
на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого элемента в массиве нет
*/

//СОЗДАНИЕ ДВМЕРНОГО МАССИВА ЗАПОЛНЕННОГО СЛУЧАЙНЫМИ ЦЕЛЫМИ ЧИСЛАМИ
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

//ВЫВОД ДВУМЕРНОГО МАССИВА В ТЕРМИНАЛЕ
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
//ПРИГЛАШЕНИЕ КО ВВОДУ
int Promt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

//========================================================================================

int[,] matrix2D1 = Create2DMatrixRndInt(3, 4, -9, 9);
Console.WriteLine("Массив:");
Print2DMatrix(matrix2D1);

Console.WriteLine("Введите позицию искомого элемента:");
int row1 = Promt("номер строки");
int column1 = Promt("номер столбца");

if (row1 <= 0 || column1 <= 0)
{
    Console.WriteLine("!!! Номер строки/столбца должен быть натуральным числом !!!");
}
else if (row1 > matrix2D1.GetLength(0) || column1 > matrix2D1.GetLength(1))
{
    Console.WriteLine("!!! Такого элемента в массиве нет !!!");
}
else
{
    Console.Write("Элемет массива в {0}-й строке {1}-м столбце: ", row1, column1);
    Console.WriteLine(matrix2D1[row1 - 1, column1 - 1]);
}
