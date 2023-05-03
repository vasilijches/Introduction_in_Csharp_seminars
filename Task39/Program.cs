/*
Напишите программу, которая
перевёрнёт одномерный массив
[1, 2, 3, 4, 5] -> [1, 2, 3, 4, 5]
[6, 7, 3, 6] -> [6, 3, 7, 6]
*/

// СОЗДАНИЕ МАССИВА СО СЛУЧАЙНЫМИ ЧИСЛАМИ
int[] CreateArrayRndInt(int length, int min, int max)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

// ВЫВОД МАССИВА В ТЕРМИНАЛЕ
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
}

// РАЗВОРОТ МАССИВА
//Array.Reverse(array);
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int[] array1 = CreateArrayRndInt(5, 1, 9);
PrintArray(array1);
Console.WriteLine();

ReverseArray(array1);
PrintArray(array1);
Console.WriteLine();

Array.Reverse(array1);
PrintArray(array1);