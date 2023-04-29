/*
Напишите цикл, который
принимает на вход два числа (А и В)
и возводит число А в натуральную степень В
3, 5 = 243
2, 4 = 16
*/
Console.WriteLine("Введите два числа");
int numA = Promt("Основание");
int numB = Promt("Показатель");

if (numB > 0)
{
    int resAB = NumberExp(numA, numB);
    Console.WriteLine($"Число {numA} в степени {numB} равно {resAB}");
}
else Console.WriteLine($"Показатель степени должен быть больше нуля!");



int NumberExp(int number1, int number2)
{
    int result = 1;
    for (int i = 0; i < number2; i++)
    {
        checked
        {
            result *= number1;
        }
    }
    return result;
}

int Promt(string text)
{
    Console.Write($"{text} степени: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}