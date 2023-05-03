/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное
45 -> 101101
3 -> 11
*/

// ПРИГЛАШЕНИЕ КО ВВОДУ
int Promt(string message)
{
    int number = -1;
    while (number < 0)
    {
        Console.Write($"{message}: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

// ПРЕОБРАЗОВАНИЕ ДЕСЯТИЧНОГО ЧИСЛА В ДВОИЧНОЕ ЧЕРЕЗ ЧИСЛА
// double DecimalToBinary(int number)
// {
//     double binNumber = 0;
//     for (int i = 0; number > 0; i++)
//     {
//         binNumber += (number % 2) * Math.Pow(10, i);
//         number /= 2;
//     }
//     return binNumber;
// }

double DecimalToBinary(int number)
{
    int count = 1;
    double binNumber = 0;
    while (number > 0)
    {
        binNumber += (number % 2) * count;
        number /= 2;
        count *= 10;
    }
    return binNumber;
}

// ПРЕОБРАЗОВАНИЕ ДЕСЯТИЧНОГО ЧИСЛА В ДВОИЧНОЕ ЧЕРЕЗ СТРОКИ
string StringDecimalToBinary(int number)
{
    string binNumber = string.Empty;
    while (number > 0)
    {
        binNumber = number % 2 + binNumber;
        number /= 2;
    }
    return binNumber;
}

int decNum1 = Promt("Введите целое положительное число");
double binNum1 = DecimalToBinary(decNum1);

Console.WriteLine($"Число {decNum1} в двоичной системе имеет вид: {binNum1}");

string binNum2 = StringDecimalToBinary(decNum1);

Console.WriteLine($"Число {decNum1} в двоичной системе имеет вид: {binNum2}");