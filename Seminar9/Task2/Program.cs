// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

// int SumNumbers(int m, int n)
// {
//     if (n == m)
//     {
//         return m;
//     }
//     return n + SumNumbers(m, n - 1);
// }

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return m + SumNumbers(m + 1, n);
}

int m = Prompt("Введите число");
int n = Prompt("Введите число");
System.Console.WriteLine(SumNumbers(m,n));
