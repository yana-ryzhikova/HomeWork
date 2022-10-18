//  Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76


double[] CreateArray(int len, int minLimit, int maxLimit)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit + 1) / 10.0;
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

double MaxNumbers(double[] array)
{
double max = array [0];
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array [i];
    }
}
return max;
}

double MinNumbers(double[] array)
{
double min = array [0];
for (int i = 0; i < array.Length; i++)
{
    if(array[i] < min)
    {
        min = array [i];
    }
}
return min;
}

double Result (double [] array)
{
    double min = array [0];
    double max = array [0];
    double res = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] < min)
    {
        min = array [i];
        res = max - min;
    }
    if(array[i] > max)
    {
        max = array [i];
        res = max - min;
    }
}
return res;
}


double [] myArray = CreateArray(10, 10, 1000);
PrintArray(myArray);
double minimum = MinNumbers(myArray);
double maximum = MaxNumbers(myArray);

Console.WriteLine($"Максимальное значение равно: {MaxNumbers(myArray)}");
Console.WriteLine($"Минимальное значение равно: {MinNumbers(myArray)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {Result(myArray)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {maximum - minimum}");
