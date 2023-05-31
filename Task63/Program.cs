/*
Задайте значение N.
Напишите программу, которая
выведет все натуральные числа от в промежутке от 1 до N
*/

System.Console.WriteLine("Введите целое положительное число:");
int number1 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers1(number1);
Console.WriteLine();
NaturalNumbers2(number1);

void NaturalNumbers1(int number)
{
    if (number == 0) return;
    NaturalNumbers1 (number - 1);
    Console.Write($"{number} ");
}

void NaturalNumbers2(int number)
{
    if (number == 0) return;    
    Console.Write($"{number} ");
    NaturalNumbers2 (number - 1);
}