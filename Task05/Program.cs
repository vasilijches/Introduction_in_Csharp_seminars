// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до +N
// Например:
// 2 -> "-2, -1, 0, 1, 2"
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int stopNumber = -number;
while(number >= stopNumber)
{
    Console.Write(-number);
    if(number > stopNumber) {Console.Write(", ");}
    number -= 1; //число уменьшается на единицу, чтобы уменьшая number добраться до -number
}