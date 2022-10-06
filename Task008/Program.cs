// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//
//6 -> да
//7 -> да
//1 -> нет



Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine( ));
if (day < 1 || day > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
else if (day >= 1 & day <= 5)
{
    Console.WriteLine("Нет");
}
else
{
     Console.WriteLine("Да");
}




if (day == 1)
{
    Console.WriteLine("Нет");
}
if (day == 2)
{
    Console.WriteLine("Нет");
}
if (day == 3)
{
    Console.WriteLine("Нет");
}
if (day == 4)
{
    Console.WriteLine("Нет");
}
if (day == 5)
{
    Console.WriteLine("Нет");
}
if (day == 6)
{
    Console.WriteLine("Да");
}
if (day == 7)
{
    Console.WriteLine("Да");
}




switch(day)
{
    case 1: Console.WriteLine("Нет");
    break;
    case 2: Console.WriteLine("Нет");
    break;
    case 3: Console.WriteLine("Нет");
    break;
    case 4: Console.WriteLine("Нет");
    break;
    case 5: Console.WriteLine("Нет");
    break;
    case 6: Console.WriteLine("Да");
    break;
    case 7: Console.WriteLine("Да");
    break;
}
