/*
Напишите программу, которая
принимает на вход натуральное число
и проверяет, является ли оно палиндромо
14212 -> нет
23432 -> да
*/
Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = ReverseNumber(num);
Console.WriteLine(result == num ? "да" : "нет");

int ReverseNumber(int number)
{
    int reverseNumber = number % 10;
    while (number > 10)
    {
        reverseNumber = reverseNumber * 10 + (number / 10) % 10;
        number = number / 10;
    }
    return reverseNumber;
}