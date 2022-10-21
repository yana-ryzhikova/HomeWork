//  Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



int Prompt(string message)
{
    System.Console.Write(message);
   int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double b1 = Prompt("Введите значение b1 => ");
double k1 = Prompt("Введите значение k1 => ");
double b2 = Prompt("Введите значение b2 => ");
double k2 = Prompt("Введите значение k2 => ");
double x = 0;
double y = 0;

bool ValidateLine (double arg1, double arg2, double arg3, double arg4)
{

    if (k1 == k2 && b1 == b2)
    {
        System.Console.WriteLine("Линии совпадают");
        return false; 
    }
    if (k1 == k2)
    {
        System.Console.WriteLine("Линии параллельные");
        return false;
    }
    return true;
}


if (ValidateLine(b1,b2,k1,k2))
{
    x = (b1 - b2)/(k2 - k1);
    y = (k2 * b1 - k1 * b2)/(k2 - k1);
    Console.WriteLine($"Координаты точки пересечения равны: х => {x:f1}, y => {y:f1}");
}


