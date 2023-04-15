// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (number >= 2)
{
    while (count <= number)
    {
        Console.Write(count+" ");
        count += 2;
    }
}
else
{
    Console.Write("Перед данным числом нет положительных чётных чисел");
}