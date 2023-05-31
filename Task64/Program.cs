/*
Задайте значение N.
Напишите программу, которая
выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии
*/

int Promt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbers(int number)
{
    if (number == 0) return;    
    Console.Write(number);
    if (number > 1) Console.Write(", ");
    NaturalNumbers (number - 1);
}

//=============================================
Console.Clear();

int number1 = Promt("Enter natural number: ");

if (number1 > 0) NaturalNumbers(number1);
else Console.WriteLine("The number must by positive!");