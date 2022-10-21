// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2


int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}




void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
}


int maxNumbersLine(int [,] arr)
{
    int max = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        max = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] > max) max = arr [i,j];
        }
        Console.WriteLine(max);
    }
    return max;
}





int[,] myArray = new int[2, 3];
PrintArray(myArray);
FillArray(myArray);
Console.WriteLine();
PrintArray(myArray);
int Maximum = maxNumbersLine(myArray);




