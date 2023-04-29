/*
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке от [10, 99].

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

int ArrayRangeNumberSum(int[] array, int minNumber, int maxNumber)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minNumber && array[i] <= maxNumber)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] arr1 = CreateArrayRndInt(20, 0, 999);

int sum1 = ArrayRangeNumberSum(arr1, 10, 99);
Console.WriteLine($"Сумма всех чисел в интервале [10, 99] в массиве равна {sum1}");