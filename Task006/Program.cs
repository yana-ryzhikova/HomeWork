// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую 
//цифру этого числа. Не использовать строки для расчета.
//
//456 -> 46
//782 -> 72
//918 -> 98


int a = new Random().Next(100, 1000);
System.Console.WriteLine(a);
int b = a / 100;
int c = a % 10;

System.Console.WriteLine($"{b}{c}");
System.Console.WriteLine($"{a / 100}{a % 10}");