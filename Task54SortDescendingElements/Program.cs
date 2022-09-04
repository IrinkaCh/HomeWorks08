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

Console.WriteLine();

int[,] SortDescendingElements(int[,] array)
{
    int[] sorted = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int e = 0; e < sorted.Length; e++)
            {
                sorted[e] = array[i, e];
            }
        }
        Array.Sort(sorted);
        Array.Reverse(sorted);
        for (int e = 0; e < sorted.Length; e++)
        {
            array[i, e] = sorted[e];
        }
    }
    return array;
}

int[,] res = SortDescendingElements(result);
Array2D(res);