// Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию 
// элементы каждой строки двумерного массива.

int[,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] DescendingLine(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int b = 0; b < array.GetLength(1) - 1; b++)
            {
                if (array[i, b] < array[i, b + 1])
                {
                    int temp = array[i, b + 1];
                    array[i, b + 1] = array[i, b];
                    array[i, b] = temp;
                }
            }
        }
    }
    return array;
}

int[,] array = CreateArray(3, 4);
PrintArray(array);
System.Console.WriteLine();
PrintArray(DescendingLine(array));
