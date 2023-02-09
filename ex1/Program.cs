/*Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 1000);
    }
    return result;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int GetEvenNumsQuantity(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}
Console.WriteLine("Задайте количество элементов в массиве:");
int dimension = Convert.ToInt32(Console.ReadLine());
int[] arr = InitArray(dimension);
PrintArray(arr);
int evenquantity = GetEvenNumsQuantity(arr);
Console.WriteLine($"Количество четных чисел в массиве: {evenquantity}");

