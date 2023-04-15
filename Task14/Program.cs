/*
Напишите программу, которая принимет на входе  число
и проверяет, кратно ли оно одновременно 7 и 23

14 -> нет
46 -> нет
161 -> да
*/

Console.Write("Введите натуральное число: ");
int numb = Convert.ToInt32(Console.ReadLine());

bool result = Multiplicity(numb, 7, 23);
Console.WriteLine(result ? "да" : "нет");

bool Multiplicity(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}