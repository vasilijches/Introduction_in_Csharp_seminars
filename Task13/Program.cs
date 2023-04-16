/*
Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите многозначное число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

if (numb1 < 0)
{
    numb1 = -numb1;
}

int numlen1 = NumberLength(numb1);
if (numlen1 < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(ThirdDigit(numb1, numlen1));
}


//METHODS:

int NumberLength(int number)
{
    int quotinent = number;
    int count = 0;
    while (quotinent != 0)
    {
        count++;
        quotinent = quotinent / 10;
    }
    return count;
}

int ThirdDigit(int number, int length)
{
    int exp = 1;
    int count = 0;
    while (count < length-3)
    {
        exp *= 10;
        count++;
    }
    return (number / exp ) % 10;
}