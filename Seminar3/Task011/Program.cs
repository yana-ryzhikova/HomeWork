﻿/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27. 
5 -> 1, 8, 27, 64, 125 */



int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N  = Prompt ("Введите число ");
for (int i = 1; i <=N; i++)
{
    System.Console.WriteLine(Math.Pow(i,3));
}