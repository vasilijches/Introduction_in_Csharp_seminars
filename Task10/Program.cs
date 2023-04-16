/*
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трёхзначное число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
if (numb1 < 0)
{
    numb1 = -numb1;
}

if (numb1 >= 100 && numb1 <= 999)
{
    Console.WriteLine(SecondDigitCut(numb1));
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число!");
}


int SecondDigitCut(int number)
{
    return number / 10 % 10;
}