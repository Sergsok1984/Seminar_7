Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) 
        {
            result[i, j] = rand.Next(-99, 99) / 10.0;
        }
    }
    return result; 
}
double[,] arr = GetArray (rows, columns);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++) 
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }