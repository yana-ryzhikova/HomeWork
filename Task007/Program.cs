// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет. Не использовать строки для расчета.
//
//645 -> 5
//78 -> третьей цифры нет
//326792 -> 6


int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите число: ");
if (number > 99 && number < 1000)
{
    int result = number % 10;
    System.Console.WriteLine(result);
}
else if (number >= 1000)
{
while (number > 999)
{
    number /= 10;
}
    int result = number % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Число не содержит третью цифру.");
}