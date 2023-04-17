/*
Напишите программу, которая
принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве
A(3,6); B(2,1) -> 5,09
A(7,-5); B(1,-1) -> 7,21
*/

Console.WriteLine("Введите координаты точки А: ");
int xA = CoordInput("X(A)");
int yA = CoordInput("Y(A)");

Console.WriteLine("Введите координаты точки B: ");
int xB = CoordInput("X(B)");
int yB = CoordInput("Y(B)");

double dist = CoordDist(xA, yA, xB, yB);
double distR = Math.Round(dist, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками А и В равно {distR}");



double CoordDist(int x1, int y1, int x2, int y2)
{
    int dx = x1 - x2;
    int dy = y1 - y2;
    double sqrt = Math.Sqrt(dx*dx + dy*dy);
    return sqrt;
}

int CoordInput(string coordinateName)
{
    System.Console.Write($"{coordinateName}: ");
    int coordinate = Convert.ToInt32(Console.ReadLine());
    return coordinate;
}