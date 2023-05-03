/*
Напишите программу, которая
принимает на вход три числа
и проверяет, может ли существовать треугольник со сторонами такой длины
(Теорема о неравенстве треугольника)
Напишите программу, которая будет преобразовывать десятичное число в двоичное
45 -> 101101
3 -> 11
*/


// ПРИГЛАШЕНИЕ КО ВВОДУ
int Promt(string message)
{
    Console.Write($"{message}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// ПРОВЕРКА ДЛИНН СТОРОН ТРЕУГОЛЬНИКА НА СООТВЕТСТВИЕ ТЕОРЕМЕ О НЕРАВЕНСТВЕ ТРЕУГОЛЬНИКА
bool IsTriangleExist(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.WriteLine("Введите длины строн треугольника: ");
int a1 = Promt("a");
int b1 = Promt("b");
int c1 = Promt("c");

bool res1 = IsTriangleExist(a1, b1, c1);
Console.Write($"Треугольник со сторонами {a1} {b1} {c1} ");
Console.WriteLine(res1 == true ? "существует" : "не существует");