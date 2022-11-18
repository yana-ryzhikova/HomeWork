// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int Function(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Function(m - 1, 1);
    }
    else
    {
        return Function(m - 1, Function(m, n - 1));
    }
}

int m = Prompt("Введите число");
int n = Prompt("Введите число");
System.Console.WriteLine(Function(m, n));
