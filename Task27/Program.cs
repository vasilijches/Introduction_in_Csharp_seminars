/*
Напишите программу, которая
принимает на вход число
и выдаёт сумму цифр в числе
*/
Console.Write($"Введите натуральное число: ");
int num1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (num1 > 0)
{
    int res1 = AllDigitSum(num1);
    Console.WriteLine($"Сумма всех цифр в числе {num1} равна {res1}");
}
else Console.Write($"Число должно быть натуральным!");


int AllDigitSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}