// // Напишите программу, которая
// на вход принимает два числа и выдаёт,
// // какое число большее, а какое меньшее
// Например:
// a = 5, b = 7 -> max = 7
// a = -9, b = -3 -> max = -3

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число, отличное от первого: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("max = " + number1);
}
else if (number2 > number1)
{
    Console.WriteLine("max = " + number2);
}
else
{
    Console.WriteLine("Вы ввели одинаковые числа");
}