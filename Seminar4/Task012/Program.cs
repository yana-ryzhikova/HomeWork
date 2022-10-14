// //  Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16 


int InputNumber(string message)
{
    System.Console.Write(message); 
    string str = Console.ReadLine(); 
    return Int16.Parse(str);      
}

int a = InputNumber("Введите первое число: ");
int b = InputNumber("Введите второе число: ");

int Resalt(int count)
{
    int result = a;
    int number = b;
    while (number > 1)
    {
        result = result * a;
        number = number - 1;
    }
    return result;
}

int Num = Resalt(a);
System.Console.WriteLine($"{a} в степени {b} = {Num}");