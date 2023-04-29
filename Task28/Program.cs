/*
Напишите программу, которая
на вход принимает число N
и выдаёт произведение чисел от 1 до N
*/

Console.Write("Введите натуральное число: ");
int num1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));

long fact = Factorial(num1);
Console.WriteLine($"Произведение чисел от 1 до {num1} равно {fact}");

long Factorial(int number)
{
    long factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    return factorial;
}
