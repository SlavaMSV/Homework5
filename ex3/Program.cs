/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double[] InitArray(int dimension)
{
    double[] result = new double[dimension];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-100, 100)/10.0;  //пока только так умею задавать вещественные числа)))
    }
    return result;
}

void PrintArray(double[] arr)
{
    Console.WriteLine("Случайный массив вещественных чисел:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void  GetMaxMinDifference(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length-1; i++)
    {
        if(arr[i+1]>max)
        {
            max=arr[i+1];
        }
        if(arr[i+1]<min)
        {
            min = arr[i+1];
        }
    }
    Console.WriteLine($"Максимальный элемент массива: {max}");
    Console.WriteLine($"Минимальный элемент массива: {min}");
double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
}

Random rnd = new Random();
int dimension = rnd.Next(0, 10);
double[] arr = InitArray(dimension);
PrintArray(arr);
GetMaxMinDifference(arr);