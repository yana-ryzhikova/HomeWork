/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */



int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int N)
{
    if (N < 10000 || N > 99999)
    {
        System.Console.WriteLine("Число не пятизначное!");
        return false;
    }
    return true;
}

int N = Prompt("Введите пятизначное число: ");
int OldNumber = N;
int NewNumber = 0;
if (!ValidateNumber(N))
{
    return;
}
    while (N > 0)
    {
        int Value = N % 10;
        NewNumber = NewNumber * 10 + Value;
        N = N / 10;
    }
    if (OldNumber == NewNumber)
    {
        System.Console.WriteLine("Число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Число не является палиндромом");
    }

