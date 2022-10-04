Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine( ));
if (value%2==0)
{
    System.Console.WriteLine($"Число {value} - четное.");
}
else
{
  System.Console.WriteLine($"Число {value} - нечетное.");  
}