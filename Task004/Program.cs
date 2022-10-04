Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine( ));
int count = 1;
while (count<=value)
if (count%2==0)
{
  System.Console.WriteLine(count); 
  count=count+1;
}
else
count=count+1;