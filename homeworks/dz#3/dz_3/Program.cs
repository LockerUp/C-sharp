﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число");
int value = int.Parse(Console.ReadLine());
double pow = 0;

for (int i = 1; i <= value; i++) {
    pow = Math.Pow(i,3);
    Console.Write($"{pow}, ");
}