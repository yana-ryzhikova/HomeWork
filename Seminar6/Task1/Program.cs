// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает 
// количество положительных)

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    System.Console.WriteLine(message);
   int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int [] EnterNumbers(int len)
{
int []array = new int[len];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Prompt($"Введите элемент массива под индексом [{i}]");
}
return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int CountPositive(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        count += 1;
    }
}
 return count;
}


int[] myArray = EnterNumbers(5);
PrintArray(myArray);
System.Console.WriteLine($"Колличество положительных чисел из введенного массива равно: {CountPositive(myArray)}");


