﻿int n = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    sum += number;
}

Console.WriteLine($"{(sum / n):F2}");