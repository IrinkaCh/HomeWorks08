Console.Write("Введите количество строк 1 матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество колонок 1 матрицы, и строк 2 матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество колонок 2 матрицы: ");
int g = Convert.ToInt32(Console.ReadLine());

int[,] FirstArray = new int[m, n];
FindArray(FirstArray);
PrintArray(FirstArray);

Console.WriteLine();

int[,] SecondArray = new int[n, g];
FindArray(SecondArray);
PrintArray(SecondArray);

void FindArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

Console.WriteLine();
int[,] resultArr = new int[m, g];
FindMultiplicationArrays(FirstArray, SecondArray, resultArr);
Console.WriteLine("Результирующая матрица:");
PrintArray(resultArr);

void FindMultiplicationArrays(int[,] FirstArray, int[,] SecondArray, int[,] resultArr)
{
    for (int i = 0; i < resultArr.GetLength(0); i++)
    {
        for (int j = 0; j < resultArr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < FirstArray.GetLength(1); k++)
            {
                sum += FirstArray[i, k] * SecondArray[k, j];
            }
            resultArr[i, j] = sum;
        }
    }
}


