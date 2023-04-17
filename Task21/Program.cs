/*
Напишите программу, которая
принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве
A(3, 6, 8); B(2, 1, -7) -> 15.84
A(7, -5, 0); B(1, -1, 9) ->11.53
*/

Console.WriteLine("Введите координаты точки А: ");
int xA = CoordInput("X(A)");
int yA = CoordInput("Y(A)");
int zA = CoordInput("Z(A)");

Console.WriteLine("Введите координаты точки B: ");
int xB = CoordInput("X(B)");
int yB = CoordInput("Y(B)");
int zB = CoordInput("Z(B)");

double dist = CoordDist(xA, yA, zA, xB, yB, zB);
double distR = Math.Round(dist, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками А и В равно {distR}");


double CoordDist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int dx = x1 - x2;
    int dy = y1 - y2;
    int dz = z1 - z2;
    double sqrt = Math.Sqrt(dx * dx + dy * dy + dz * dz);
    return sqrt;
}

int CoordInput(string coordinateName)
{
    System.Console.Write($"{coordinateName}: ");
    int coordinate = Convert.ToInt32(Console.ReadLine());
    return coordinate;
}