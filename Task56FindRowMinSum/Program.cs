System.Console.Write("Введите количество строк: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
System.Console.Write("Введите количество колонок: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    Console.WriteLine("Введены не правильные данные.");
    return;
}
int[,] result = FillArray2D(m, n, 1, 9);
Array2D(result);

int[,] FillArray2D(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Array2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindRowMinSum(int[,] array)
{

    int sum = int.MaxValue;
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int minsum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minsum += array[i, j];
        }
        if (minsum < sum)
        {
            sum = minsum;
            number = i;
        }
    }
    return number;
}
Console.WriteLine();
int res = FindRowMinSum(result);
Console.WriteLine(res + " cтрока");

