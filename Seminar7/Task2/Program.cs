//  Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет


int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

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


(int, int, int) Search(int[,] array)
{
    int line = Prompt("Введите позицию элемента Строка => ");
    int column = Prompt("Введите позицию элемента Столбец => ");
    int number = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == line && j == column)
            {
                number = array [i,j];
                System.Console.WriteLine($"Позициям [{line}, {column}] соответствует элемент со значением {array[i,j]}");
            }
        } 
    }
    return (line, column, number);
}

    int[,] array = CreateArray(3, 4);
    PrintArray(array);
    (int line, int column, int number) = Search(array);
    if (number == -1)
    {
        System.Console.WriteLine($"Элемента с позициями [{line}, {column}]  не существует в данном массиве");
    }
    