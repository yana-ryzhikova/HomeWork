// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] CreateArray(int lenRow, int lenColumns)
{
    int[,] array = new int[lenRow, lenColumns];
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
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

double ColumnsAverage(int[,] array)
{
        double sum = 0;
        double average = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0;
        average = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
            average = sum / array.GetLength(0);
        }
        Console.WriteLine("Среднее арифметическое элементов столбца с индексом {0}: {1:f1}", i, average);
    }
    return sum;
}

int[,] array = CreateArray(3, 4);
PrintArray(array);
double average = ColumnsAverage(array);

