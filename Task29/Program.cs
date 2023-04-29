/*
Напишите программу, которая
задаёт массив из 8 элементов,
заполенный псевдослучайными числами
и выводит их на экран
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
*/

Console.Write("Введите длину массива: ");
int length1 = Convert.ToInt32(Console.ReadLine());
int[] arr1 = new int[length1];

FillArray(arr1);
PrintArray(arr1);

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.Write($"{array[array.Length-1]}]");
}
//