/*
Напишите программу замены элементов массива:
положительные элементы на соответствующие отрицательные, и наоборот
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int Promt(string message) // приглашение ко вводу
{
    Console.Write($"{message}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

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

void PrintArray(int[] array) // вывод случайного массива
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ", 2);
        else Console.Write(array[i]);
    }
}

void ArrayInversion (int[] array) // умножение элементов массива на -1
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

int length1 = Promt("Введите длину массива");
int min1 = Promt("Введите минимальное значение элемента массива");
int max1 = Promt("Введите максимальное значение элемента массива");

int[] arr1 = CreateArrayRndInt(length1, min1, max1);

ArrayInversion(arr1);
PrintArray(arr1);