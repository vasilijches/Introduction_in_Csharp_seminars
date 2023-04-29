/*
Напишите программу, которая
принимет на вход число (А)
и выдаёт сумму чисел от 1 до А
7 -> 28
4 -> 10
8 -> 36
*/
Console.Write("Введите натуральное число: ");
long a = Math.Abs(Convert.ToInt32(Console.ReadLine()));

long sumNumbers = SumNumbers(a);
Console.WriteLine($"Сумма чисел от 0 до {a} равна {sumNumbers}");

long SumNumbers(long number)
{
    long sum = 0;
    for (int i = 1; i <= number; i++)
    {
        checked
        {
            sum += i;
        }        
    }
    return sum;
}
