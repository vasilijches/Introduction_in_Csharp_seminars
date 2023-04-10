// Напишите программу, которая принимет на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// Например:
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трёхзначное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 < 0)
{
    number1 = -number1;
}
if (number1 >= 100 && number1 <= 999)
{
    Console.WriteLine(number1 % 10);
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число!");
}