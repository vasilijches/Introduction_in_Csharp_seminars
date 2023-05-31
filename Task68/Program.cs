/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
*/

int Promt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackerman(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberN == 0) return Ackerman(numberM - 1, 1);
    else return Ackerman(numberM - 1, Ackerman(numberM, numberN - 1));
}

//=============================================================

Console.Clear();

int numberM1 = Promt("Enter positive integer M: ");
int numberN1 = Promt("Enter positive integer N: ");

if (numberM1 < 0 || numberN1 < 0)
{
    Console.WriteLine("The numbers must be non-negative");
}
else
{
    Console.Write($"ack({numberM1}, {numberN1}) = ");
    Console.WriteLine(Ackerman(numberM1, numberN1));
}