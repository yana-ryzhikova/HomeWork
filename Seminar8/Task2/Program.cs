// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


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
void PrintArrays(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int[] SumLen(int[,] array)
{
    int[] summ = new int[array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        summ[i] = sum;
        sum = 0;
    }
    return summ;
}


int MinSum(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}


void ResaltLenArray(int[,] array)
{
    int i = MinSum(SumLen(array));
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] array = CreateArray(3, 4);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Суммы элементов по строкам равны:");
PrintArrays(SumLen(array));
int[] myArray = SumLen(array);
System.Console.WriteLine();
System.Console.WriteLine($"Индекс строки с минимальной суммой элементов равен {(MinSum(SumLen(array)))}");
ResaltLenArray(array);


