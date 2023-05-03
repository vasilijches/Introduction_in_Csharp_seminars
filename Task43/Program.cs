/*
Напишите программу, которая
найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
Например:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//ПРИГЛАШЕНИЕ КО ВВОДУ
double Promt(string message)
{
    Console.Write(message + ": ");
    return Convert.ToDouble(Console.ReadLine());
}

//РАСЧЁТ АБСЦИССЫ ТОЧКИ ПЕРЕСЕЧЕНИЯ ДВУХ ПРЯМЫХ
double IntersectionPointAbscissa (double kA, double bA, double kB, double bB)
{
    double result = (bB - bA) / (kA - kB);
    return result;
}

//РАСЧЁТ АБСЦИССЫ ТОЧКИ ПЕРЕСЕЧЕНИЯ ДВУХ ПРЯМЫХ
double IntersectionPointOrdinate (double kA, double bA, double kB, double bB)
{
    double result = (kB*bA - kA*bB) / (kB - kA);
    return result;
}

//--------------------------------------------------------------------------------------

Console.WriteLine("Введите коэффициенты уравнения первой прямой y = k1*x + b1");
double k1 = Promt("k1");
double b1 = Promt("b1");

Console.WriteLine("Введите коэффициенты уравнения второй прямой y = k2*x + b2");
double k2 = Promt("k2");
double b2 = Promt("b2");

double xISP = IntersectionPointAbscissa (k1, b1, k2, b2);
xISP = Math.Round(xISP, 2);

double yISP = IntersectionPointOrdinate (k1, b1, k2, b2);
yISP = Math.Round(yISP, 2);

Console.WriteLine($"Точка пересечения прямых y = {k1}*x + {b1} и y = {k2}*x + {b2}");
Console.WriteLine($"имеет координаты: ({xISP}; {yISP})");

