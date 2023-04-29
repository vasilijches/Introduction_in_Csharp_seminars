/*
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

// ПОДСЧЁТ СУММЫ ЭЛЕМЕНТОВ МАССИВА С НЕЧЁТНЫМИ ИНДЕКСАМИ
int ArrayEvenElementCounting (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Подсчёт суммы элементов в массива на нечётных позициях");
int[] arr1 = CreateArrayRndInt(6, -30, 30);

Console.Write("[");
PrintArray(arr1);
Console.Write("] -> ");

int evenElementAmount = ArrayEvenElementCounting(arr1);

Console.WriteLine(evenElementAmount);