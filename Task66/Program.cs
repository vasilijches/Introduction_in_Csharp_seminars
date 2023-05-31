/*
Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N.
*/

int Promt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int IntervalNumberSum (int numberM, int numberN)
{
    return numberM == numberN ? numberM : numberM + IntervalNumberSum(numberM + 1, numberN);
}

//======================================================================================

Console.Clear();

int numberM1 = Promt("Enter positive integer M: ");
int numberN1 = Promt("Enter positive integer N: ");

if(numberM1 <= 0 || numberN1 <= 0)
{
    Console.WriteLine("The numbers must be positive!");
}
else if(numberM1 <= numberN1)
{
    Console.Write($"The sum of integers of [{numberM1}, {numberN1}] is ");
    Console.WriteLine(IntervalNumberSum(numberM1, numberN1));
}
else
{
    Console.Write($"The sum of integers of [{numberN1}, {numberM1}] is ");
    Console.WriteLine(IntervalNumberSum(numberN1, numberM1));
}