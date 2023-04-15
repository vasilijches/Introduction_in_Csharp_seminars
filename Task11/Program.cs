/*
Напишите программу, которая выводит случайное трёхзначное число
и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int threeDigitNumber = new Random().Next(100, 1000);
Console.WriteLine($"The three-digit number is {threeDigitNumber}");

int twoDigitNumber = SecondNumberCut(threeDigitNumber);
Console.WriteLine($"The two-digit number is {twoDigitNumber}");

int SecondNumberCut(int number)
{
    int cutNumber = (number / 100) * 10 + number % 10;
    return cutNumber;
}
