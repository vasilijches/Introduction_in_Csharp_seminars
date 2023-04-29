/*

*/
Console.Write("Введите длину массива: ");
int length1 = Convert.ToInt32(Console.ReadLine());
int[] arr1 = new int[length1];

FillArray(arr1);

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);
        Console.Write(array[i]+" ");
    }
}