/*
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь
*/

//ПРИГЛАШЕНИЕ КО ВВОДУ
int Promt(string message)
{
    Console.Write(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

//СОЗДАНИЕ МАССИВА РУЧНЫМ ВВОДОМ
int[] ArrayManualImput(int arraySize)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.Write($"Введите {i + 1}-e число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Ввод чисел завершён.");
    return array;
}

//ВЫВОД МАССИВА В ТЕРМИНАЛЕ
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
}

//ПОДСЧЁТ КОЛИЧЕСТВА ПОЛОЖИТЕЛЬНЫХ ЧИСЕЛ В МАССИВЕ
int ArrayPositiveNumberCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

//----------------------------------------------------------------------------------------

int size1 = Promt("Введите количество вводимых чисел");
int[] arr1 = ArrayManualImput(size1);
int posNumCount1 = ArrayPositiveNumberCount(arr1);

PrintArray(arr1);
Console.Write(" -> ");
Console.WriteLine(posNumCount1);