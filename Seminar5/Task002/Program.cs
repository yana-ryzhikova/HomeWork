//  Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0


int[] CreateArray(int len, int minLimit, int maxLimit)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int Numbers(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + array [i] ;
    }
}
return sum;
}



int SumNumbers(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0)
    {
        sum = sum + array [i] ;
    }
}
return sum;
}

int [] myArray = CreateArray(10, 0, 10);
PrintArray(myArray);
Console.WriteLine($"Сумма чисел с нечетными позициями равна: {SumNumbers(myArray)}");
Console.WriteLine($"Сумма чисел с нечетным индексом равна: {Numbers(myArray)}");