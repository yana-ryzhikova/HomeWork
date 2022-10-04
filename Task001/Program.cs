Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine( ));
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine( ));
if (a<b)
{
    System.Console.WriteLine($"{a}=min,{b}=max");
}
else if (a>b)
{
    System.Console.WriteLine($"{b}=min,{a}=max");
}
else
{
   System.Console.WriteLine($"{a}={b}");
}
