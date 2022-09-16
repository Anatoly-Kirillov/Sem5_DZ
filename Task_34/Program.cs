// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int countEvNum(int[] array)
{
    int res = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) res++;
    }
    return res;
}
Console.Write("Введите количество элементов массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное трёхзначное значение массива: ");
int arrStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное трёхзначное число массива: ");
int arrEnd = Convert.ToInt32(Console.ReadLine());
int[] myArray = GetArray(arrSize, arrStart, arrEnd);
int result = countEvNum(myArray);
if(arrStart <= 99 && arrEnd >= 1000)
{
    Console.WriteLine("Вы ввели не трёхзначное число, введи трёхзначное");
}
Console.Write($"[{String.Join(", ", myArray)}]");
Console.Write($" -> {String.Join(", ", result)}");