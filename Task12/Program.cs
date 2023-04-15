/*
Напишите программу, которая
будет принимать на вход два числа и выводить,
является ли первое число кратным второму.
Если первое число не кратно второму, то
программа будет выводитьостаток от деления
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

Console.WriteLine("Enter the first number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

int rem = DivRemainder(numb1, numb2);
if (rem == 0)
{
    Console.WriteLine($"кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {rem}");
}


int DivRemainder(int number1, int number2)
{
    return number1 % number2;    
}