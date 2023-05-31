/*
Задайте значения M и N.
Напишите программу, которая
выведет все натуральные числа
в промежутке от M до N.
*/

int Promt(string message)
{
    Console.Write(message+" ");
    return Convert.ToInt32(Console.ReadLine());
}

void IntegerNumberInterval (int numberM, int numberN)
{
    Console.Write(numberM);
    if(numberM < numberN) IntegerNumberInterval(numberM + 1, numberN);
    else if(numberM > numberN) IntegerNumberInterval(numberM - 1, numberN);    
}

//=====================================================================

Console.Clear();

int number1 = Promt("Enter the first natural number: ");
int number2 = Promt("Enter the second natural number: ");

IntegerNumberInterval(number1, number2);