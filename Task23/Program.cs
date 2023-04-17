/*
Напишите программу, которая
принимает на вход число (N)
и выдаёт таблицу кубов числе от 1 до N
*/

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0) QTab(num);
else Console.WriteLine("Вы ввели не натуральное число!");


void QTab(int number)
{
    int count = 1;
    while (count <= number)
    {
        System.Console.WriteLine($"{count, 3} {Math.Pow(count, 3), 10}");
        count++;
    }
}