/*
Задайте массив из 12 элементов,
заполненный случайными числами из промежутка [-9; 9].
Найдите сумму отрицательных и положительных элементов массива

[3,9,-8,1,0,-7,2,-1,8,-3,-1,6] -> -20, 29
*/
int length1 = Promt("Введите длину массива");
int min1 = Promt("Введите минимальное значение элемента массива");
int max1 = Promt("Введите максимальное значение элемента массива");

int[] arr1 = CreateArrayRndInt(length1, min1, max1);
PrintArray(arr1);

Console.WriteLine();
int negSum = PartArrSum(arr1, false);
Console.WriteLine("Сумма всех отрицательных чисел массива: {0}", negSum);

int posSum = PartArrSum(arr1, true);
Console.WriteLine("Сумма всех положительных чисел массива: {0}", posSum);


int Promt(string message)
{
    Console.Write($"{message}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArrayRndInt(int length, int min, int max)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length ; i++)
    {
        array[i] = random.Next(min, max + 1);

    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
}

int PartArrSum(int[] array, bool sign)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (sign == true && array[i] < 0) continue;
        else if (sign == false && array[i] > 0) continue;
        else sum = sum + array[i];
    }
    return sum;
}

