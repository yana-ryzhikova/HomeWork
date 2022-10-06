//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа. Не использовать строки для расчета.
//
//456 -> 5
//782 -> 8
//918 -> 1


int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите число: ");
if (number > 99 & number < 1000)
{
    int result = number / 10 % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Число не является трехзначным");
}
