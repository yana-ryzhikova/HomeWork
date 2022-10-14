// //  Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 -> 8


// Printer(Fill(8));

// int [] Fill(int Length)
// {
//     int [] array = new int [Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         int r = new Random().Next(0, 100);
//         array[i] = r;
//     }
//     return array;
// }

// void Printer(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

int [] Fill(int Length)
{
    int [] array = new int [Length];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(0, 100);
        Console.WriteLine($"{array[i]} ");
    }
    return array;
}

int [] res = Fill((8));

Random rand = new Random();
{
int [] array = new int [8];
for (int i = 0; i < array.Length; i++)
    {
        array [i] = rand.Next(100);
        Console.Write($"{array[i]} ");
    }
}

