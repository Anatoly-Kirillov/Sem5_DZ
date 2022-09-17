// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int oddIndexSum(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

Console.Write("Введите количество элементов массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int arrStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int arrEnd = Convert.ToInt32(Console.ReadLine());
int[] newArray = GetArray(arrSize, arrStart, arrEnd);
Console.Write($"Массив: [{String.Join(", ", newArray)}]");
int result = oddIndexSum(newArray);
Console.Write($" -> {result}");
