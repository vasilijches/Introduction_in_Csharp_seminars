/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите номер дня недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

if (dayNum > 0 && dayNum < 8)
{
    Console.WriteLine(IsWeekend(dayNum) == true ? "да" : "нет"); 
}
else 
{
    Console.WriteLine("нет такого дня недели");
}


bool IsWeekend(int dayNumber)
{
    return dayNumber > 5 && dayNumber <8;
}