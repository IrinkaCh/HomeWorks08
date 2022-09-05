int[,,] array3D = new int[2, 2, 2];
FindNumberArray3D(array3D);
PrintArray(array3D);


void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

void FindNumberArray3D(int[,,] array3D)
{
    int[] res = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < res.GetLength(0); i++)
    {
        res[i] = new Random().Next(10, 100);
        number = res[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (res[i] == res[j])
                {
                    res[i] = new Random().Next(10, 100);
                    j = 0;
                    number = res[i];
                }
                number = res[i];
            }
        }
    }

    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = res[count];
                count++;
            }
        }
    }
}

