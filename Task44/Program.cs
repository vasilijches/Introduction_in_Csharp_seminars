/*
Не используя рекурсию
выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи 0 и 1
*/

// ПРИГЛАШЕНИЕ КО ВВОДУ С УСЛОВИЕМ
//condition1: true - ">", false - "<"; condition2: "1" for natural numbers
// int Promt(string message, bool condition1, int condition2) 
// {
//     Console.Write($"{message}: ");
//     int number = Convert.ToInt32(Console.ReadLine());
    
//     string condition = condition1
//                                 ? $"{number < condition2}"
//                                 : $"{number > condition2}";

//     while (Convert.ToBoolean(condition))
//     {
//         Console.WriteLine($"Число не соответствует условиям! Введите другое число!");
//         Console.Write($"{message}: ");
//         number = Convert.ToInt32(Console.ReadLine());
//         condition = condition1
//                                 ? $"{number < condition2}"
//                                 : $"{number > condition2}";
//     }
//     return number;
// }

// // РАСЧЁТ N-ного ЧИСЛА ФИБОНАЧЧИ
// int Fibonacci(int numberN)
// {
//     int number1 = 0;
//     int number2 = 1;
//     int fibNumber = 0;
    
//     if (numberN == 1) fibNumber = number1;
//     else if (numberN == 2) fibNumber = number2;
    
//     else
//     {
//         int count = 3;
//         while (count <= numberN)
//         {
//             fibNumber = number2 + number1;
//             number1 = number2;
//             number2 = fibNumber;
//             count++;
//         }
//     }
//     return fibNumber;
// }

// int num1 = Promt("Введите целое положительное число", true, 1);

// int fibNum1 = Fibonacci(num1);
// Console.WriteLine($"Число Фибоначчи с номером {num1} равно {fibNum1}");

// ПРИГЛАШЕНИЕ КО ВВОДУ
int Promt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

// СОЗДАНИЕ МАССИВА, ЗАПОЛНЕННОГО ЧИСЛАМИ ФИБОНАЧЧИ
int[] Fibonacci(int size)
{
    int[] array = new int[size];
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

// ВЫВОД МАССИВА В ТЕРМИНАЛЕ
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
}

int num1 = Promt("Введите натуральное число: ");
if (num1 > 0)
{
    int[] arr1 = Fibonacci(num1);
    PrintArray(arr1);
}
else Console.WriteLine("Число должно быть натуральным!");