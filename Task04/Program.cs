// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел
// Например:
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Вседите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вседите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вседите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number2 > max) { max = number2; }
if (number3 > max) { max = number3; }
Console.WriteLine("max = " + max);