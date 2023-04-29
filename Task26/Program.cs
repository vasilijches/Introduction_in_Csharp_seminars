/*
Напишите программу, которая
принимает на вход число
и выдаёт количество цифр в числе
456 -> 3
78 -> 2
89126 -> 5
*/
Console.Write("Введите целое число: ");
long num1 = Math.Abs(Convert.ToInt64(Console.ReadLine()));

int digitNum = DigitNumber(num1);
string word = NumberDeclination(digitNum);

Console.WriteLine($"В числе {num1} содержится {digitNum} {word}");


string NumberDeclination(int digit)
{
    string result;
    if (digit % 100 >= 11 && digit %100 <= 14)     result = "цифр";
    else if (digit % 10 == 1)                      result = "цифра"; 
    else if (digit % 10 >= 2 && digit <= 4 )       result = "цифры";
    else result = "цифр";
    return result;
}

int DigitNumber(long number)
{
    int count = 1;
    while (number >= 10)
    {
        number /= 10;
        count++;
    }
    return count;
}