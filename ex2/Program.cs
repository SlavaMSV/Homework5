/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-100, 100);
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("Случайный массив целых чисел:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int GetUnevenPositionSum(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        result+=arr[i];
    }
    return result;
}

Random rnd = new Random();
int dimension = rnd.Next(0, 10);

int[] arr = InitArray(dimension);
PrintArray(arr);
int unevenPositionSum = GetUnevenPositionSum(arr);
Console.WriteLine($"Сумма элементов массива на нечетных позициях: {unevenPositionSum}");
