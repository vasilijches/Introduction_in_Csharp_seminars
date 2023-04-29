/*
Найдите произведение пар чисел в одномерном массиве.
Парой считается первый и последний элементы, второй и предпоследний элементы и т.д.
Результат запишите в новом массиве
[1 2 3 4 5] -> 5 8 3
[6 7 8 9] -> 36 21
*/

int[] CreateArrayRndInt(int length, int min, int max) // создание случайного массива
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);        
    }
    return array;
}

void PrintArray(int[] array) // вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ", 2);
        else Console.Write(array[i]);
    }
}

int[] ArrayTransformation(int[] array)
{
    int transArrayLength = (array.Length + 1) / 2;
    int stopIndex = array.Length / 2;

    int[] transArray = new int[transArrayLength];
    
    for (int i = 0; i < stopIndex; i++)
    {
        transArray[i] = array[i] * array[array.Length - 1 - i];
    }
    
    if (transArrayLength % 2 == 1) 
    {
        transArray[transArrayLength-1] = array[stopIndex];
    }
    
    return transArray;
}

int[] arr1 = CreateArrayRndInt(4, 1, 10);
Console.Write("[");
PrintArray(arr1);
Console.Write("] -> ");

int[] transArr2 = ArrayTransformation(arr1);
Console.Write("[");
PrintArray(transArr2);
Console.Write("]");