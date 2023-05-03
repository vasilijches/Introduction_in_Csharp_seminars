/*
Напишите программу, которая
будет создавать копию данного массива
с помощью поэлементного копирования
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

// СОЗДАНИЕ КОПИИ МАССИВА
int[] ArrayCopy(int[] array)
{
    int[] resultArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        resultArray[i] = array[i];
    }
    return resultArray;
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


int[] arr1 = CreateArrayRndInt(10, 1, 9);
PrintArray(arr1);
Console.WriteLine();

int[] arrCopy1 = ArrayCopy(arr1);
arrCopy1[0] = arrCopy1.Length;
PrintArray(arrCopy1);
