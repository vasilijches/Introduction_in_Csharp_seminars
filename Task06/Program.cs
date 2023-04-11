// Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным
// Например:
// 4 -> да
// -3 -> нет

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) { Console.WriteLine("Да"); }
else { Console.WriteLine("Нет"); }