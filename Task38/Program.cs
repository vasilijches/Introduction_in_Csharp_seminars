/*
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементами массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/

// СОЗДАНИЕ МАССИВА СО СЛУЧАЙНЫМИ ВЕЩЕСТВЕННЫМИ ЧИСЛАМИ
double[] CreateArrayRndDouble(int length, int min, int max)
{
    double[] array = new double[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * (max - min) + min;        
    }
    return array;
}

// ВЫВОД МАССИВА ВЕЩЕСТВЕННЫХ ЧИСЕЛ С ЗАДАННОЙ ТОЧНОСТЬЮ И С ЗАМЕНОЙ ЗАПЯТОЙ НА ТОЧКУ
void PrintArray(double[] array, int precision) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(array[i], precision); // округление
        
        string stringNumber;
        stringNumber = Convert.ToString(array[i]);  // преобразование числа в строку
        Console.Write(stringNumber.Replace(",", ".")); // замена в строке "," на "."

        if (i < array.Length - 1) Console.Write(", ");
    }
}

// ВЫЧИСЛЕНИЕ РАЗНОСТИ МЕЖДУ МАКСИМАЛЬНЫМ И МИНИМАЛЬНЫМ ЗНАЧЕНИЕМ МАССИВА
double ArrayMinMaxDiff (double[] array)
{
    double min = array[0];
    double max = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min;
}


Console.WriteLine("Подсчёт количества чётных элементов в массиве");
double[] arr1 = CreateArrayRndDouble(10, 0, 100);

Console.Write("[");
PrintArray(arr1, 1);
Console.Write("] -> ");

double maxMinDiff1 = ArrayMinMaxDiff(arr1);
maxMinDiff1 = Math.Round(maxMinDiff1, 1);

string strNum1 = Convert.ToString(maxMinDiff1);
Console.WriteLine(strNum1.Replace(",", "."));

