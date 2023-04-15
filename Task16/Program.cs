/*
Напишите программу, которая принимет на вход два числа
и проверяет, является ли одно число квадратом другого
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8, 9 ->нет
*/

Console.Write("Введите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

bool result = IsSquare(numb1, numb2);
Console.WriteLine(result ? "да" : "нет");

bool IsSquare(int num1, int num2)
{
    return (num1 == num2 * num2) || (num2 == num1 * num1);
}