/*
Напишите программу, которая
принимает на вход число (N)
и выдаёт таблицу квадратов чисел от 1 до N
1   1
2   4
3   9
4   16
*/

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

SqTab(num);


void SqTab(int number)
{
    int count = 1;
    while (count <= number)
    {
        System.Console.WriteLine($"{count, 5}   {count * count, 5}");
        count++;
    }
}