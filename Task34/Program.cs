/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве
[345, 897, 568, 234] -> 2
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
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
}

// ПОДСЧЁТ КОЛИЧЕСТВА ЧЁТНЫХ ЭЛЕМЕНТОВ МАССИВА
int ArrayEvenElementCounting (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) count++;
    }
    return count;
}


Console.WriteLine("Подсчёт количества чётных элементов в массиве");
int[] arr1 = CreateArrayRndInt(10, 100, 999);

Console.Write("[");
PrintArray(arr1);
Console.Write("] -> ");

int evenElementAmount = ArrayEvenElementCounting(arr1);

Console.WriteLine(evenElementAmount);