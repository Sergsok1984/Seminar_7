int[,] numbers = new int[5, 5];
FillArray(numbers);
PrintArray(numbers);

double[] average = new double[numbers.GetLength(1)];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }   
}

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result += numbers[j, i];
    }
    average[i] = result / numbers.GetLength(0);
}

void PrintArrayAverage(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");

    }    
    Console.WriteLine();
}

Console.Write("Среднее-арифметическое каждого столбца: ");
PrintArrayAverage(average);
Console.WriteLine();