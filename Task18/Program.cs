/*
Напишите программу, которая
по заданному номеру четверти
показывает диапазон возможных координат точек этой четверти (x и y)
*/

Console.Write("Введите номер четверти: ");
int quarter1 = Convert.ToInt32(Console.ReadLine());

string range = CoordRange(quarter1);
string result = range != null
                    ? $"В указанной четверти диапазон возможных координат точек: {range}"
                    : "Четверти с таким номером не существует";
Console.WriteLine(result);

string CoordRange(int quarter)
{
    if (quarter == 1) return "x > 0, y > 0";
    if (quarter == 2) return "x < 0, y > 0";
    if (quarter == 3) return "x < 0, y < 0";
    if (quarter == 4) return "x > 0, y < 0";
    return null;
}