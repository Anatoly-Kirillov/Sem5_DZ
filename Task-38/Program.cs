// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int FindMax(int[] array)
{
    int result = array[0];
    foreach (int el in array)
    {
        if (el > result) result = el;
    }
    return result;
}
int FindMin(int[] array)
{
    int result = array[0];
    foreach (int el in array)
    {
        if (el < result) result = el;
    }
    return result;
}
Console.Write("Введите длинну массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrEnd = Convert.ToInt32(Console.ReadLine());
int[] newArray = GetArray(arrSize, arrStart, arrEnd);
Console.Write($"Массив: [{String.Join(" ", newArray)}]");
int maxElement = FindMax(newArray);
int minElement = FindMin(newArray);
double minMax = maxElement - minElement;
Console.WriteLine($" -> {minMax}");


