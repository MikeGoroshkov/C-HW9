﻿/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Main();

void Main()
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write(SummBetween(m, n));
}

int SummBetween(int m, int n)
{
    if (m == n) return m;
    return n + SummBetween(m, n - 1);
}