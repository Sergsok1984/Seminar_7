﻿int[,] numbers = new int[5, 5];
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(99);
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
    Console.WriteLine();
}
Console.WriteLine("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());
if (rows < numbers.GetLength(0) && columns < numbers.GetLength(1)) 
    Console.WriteLine($"Значение элемента в указанной позиции: {numbers[rows, columns]}");
else Console.WriteLine("Указанной позиции не существует!");