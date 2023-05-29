/*
Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.
*/


//ЗАДАНИЕ ДВУМЕРНОГО МАССИВА СЛУЧАЙНОГО РАЗМЕРА СО СЛУЧАЙНЫМИ ЧИСЛАМИ
int[,] RandomMatrixCreate(int maxSize, int min, int max)
{
    Random size = new Random();
    int[,] matrix = new int[size.Next(1, maxSize + 1), size.Next(1, maxSize + 1)];

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

// ВЫВОД ДВУМЕРНОГО МАССИВА В ТЕРМИНАЛЕ
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

// ПРОВЕРКА ДВУХ МАТРИЦ НА ВОЗМОЖНОСТЬ ПЕРЕМНОЖЕНИЯ
bool MatrixMultiValidate(int[,] matrixA, int[,] matrixB)
{
    return matrixA.GetLength(1) == matrixB.GetLength(0);
}

// ПЕРЕМНОЖЕНИЕ СТРОКИ ОДНОЙ МАТРИЦЫ НА СТОЛБЕЦ ДРУГОЙ МАТРИЦЫ
int MatrixRowColumnMultiply(int[,] matrixA, int[,] matrixB, int rowA, int columnB)
{
    int sum = 0;
    for (int i = 0; i < matrixA.GetLength(1); i++)
    {
        sum += matrixA[rowA, i] * matrixB[i, columnB];
    }
    return sum;
}

// ПЕРЕМНОЖЕНИЕ ДВУХ МАТРИЦ
int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB)
{
    int resultRows = matrixA.GetLength(0);
    int resutlColumns = matrixB.GetLength(1);
    int[,] resultMatrix = new int[resultRows, resutlColumns];

    for (int i = 0; i < resultRows; i++)
    {
        for (int j = 0; j < resutlColumns; j++)
        {
            resultMatrix[i, j] = MatrixRowColumnMultiply(matrixA, matrixB, i, j);
        }
    }
    return resultMatrix;
}

//===========================================================================

Console.Clear();

int[,] matrix2D1 = RandomMatrixCreate(3, 1, 9);
int[,] matrix2D2 = RandomMatrixCreate(3, 1, 9);

Console.WriteLine("Matrix A:");
Print2DMatrix(matrix2D1);
Console.WriteLine();

Console.WriteLine("Matrix B:");
Print2DMatrix(matrix2D2);
Console.WriteLine();

if (MatrixMultiValidate(matrix2D1, matrix2D2)) 
{    
    int[,] multResulMatrix = MatrixMultiply(matrix2D1, matrix2D2); 

    Console.WriteLine("Matrix A x B");
    Print2DMatrix(multResulMatrix);
}
else
{
    Console.WriteLine("Данные матрицы нельзя перемножить в указанном порядке!");  
}

Console.WriteLine();