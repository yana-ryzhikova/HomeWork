//  Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int InputNumber(string message)
{
    System.Console.Write(message); 
    string str = Console.ReadLine(); 
    return Int16.Parse(str);      
}


int SumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int value = number % 10;
        sum = sum + value;
        number = number / 10;
    }
    return sum;
}
bool ValidateNumber(int number)
{
    if (number < 10) // При числе меньше чем 1 не работаем
    {
        System.Console.WriteLine("Число однозначное, сумма не считается");
        return false;
    }
    return true;
}

int N = InputNumber("Введите число: ");
if(ValidateNumber(N))
{
int Num = SumNumbers(N);
System.Console.WriteLine($"Сумма чисел {N} равна {Num}.");
}