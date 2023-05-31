/*
Напишите программу, которая
на вход принимает два числа А и В
и возводит число А в целую степень В
с помощью рекурсии
*/

int Promt(string message)
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int Exponent(int numberA, int numberB)
{
    return numberB == 0 ? 1 : numberA * Exponent(numberA, numberB - 1);
}

//=====================================================================
Console.Clear();

int number1 = Promt("Введите целое число А: ");
int number2 = Promt("Введите натуральное В: ");

if (number2 >= 0)
{
int exp1 = Exponent(number1, number2);
Console.WriteLine(exp1);
}
else Console.WriteLine("Число должно В быть положительным");