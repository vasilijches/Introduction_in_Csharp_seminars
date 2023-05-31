/*
Напишите программму, которая
будет принимать на вход число
и возвращать сумму его цифр
*/

int Promt(string message)
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int DigitSum(int number)
{
    return number == 0 ? 0 : number % 10 + DigitSum(number / 10);
}

//=======================================================
Console.Clear();

int number1 = Promt("Введите целое число: ");
Console.WriteLine();

int sum1 = DigitSum(number1);
Console.WriteLine(sum1);