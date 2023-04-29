/*
Задайте массив. Напишите программу,которая
определяет, присутствует ли заданное число в массиве
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

void PrintArray(int[] array) // вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ", 2);
        else Console.Write(array[i]);
    }
}

bool NumberFind(int[] array, int number) // поиск числа в массиве
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}


int length1 = Promt("Введите длину массива");
int min1 = Promt("Введите минимальное значение элемента массива");
int max1 = Promt("Введите максимальное значение элемента массива");

int[] arr1 = CreateArrayRndInt(length1, min1, max1);

PrintArray(arr1);
Console.WriteLine();

int num1 = Promt("Введите искомое число");
bool res1 = NumberFind(arr1, num1);
Console.WriteLine(res1 ? "да" : "нет");