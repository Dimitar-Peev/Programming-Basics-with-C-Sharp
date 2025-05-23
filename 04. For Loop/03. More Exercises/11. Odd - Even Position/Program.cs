﻿int n = int.Parse(Console.ReadLine());

double oddSum = 0.0;
double oddMin = 1000000000.0;
double oddMax = -1000000000.0;
double evenSum = 0.0;
double evenMin = 1000000000.0;
double evenMax = -1000000000.0;

for (int i = 1; i <= n; i++)
{
    double num = double.Parse(Console.ReadLine());
    if (i % 2 != 0)
    {
        oddSum += num;
        if (num < oddMin)
        {
            oddMin = num;
        }
        if (num > oddMax)
        {
            oddMax = num;
        }
    }
    else
    {
        evenSum += num;

        if (num < evenMin)
        {
            evenMin = num;
        }
        if (num > evenMax)
        {
            evenMax = num;
        }
    }
}

Console.WriteLine($"OddSum={oddSum:F2},");

if (oddMin == 1000000000.0)
{
    Console.WriteLine("OddMin=No,");
}
else
{
    Console.WriteLine($"OddMin={oddMin:F2},");
}

if (oddMax == -1000000000.0)
{
    Console.WriteLine("OddMax=No,");
}
else
{
    Console.WriteLine($"OddMax={oddMax:F2},");
}

Console.WriteLine($"EvenSum={evenSum:F2},");

if (evenMin == 1000000000.0)
{
    Console.WriteLine("EvenMin=No,");
}
else
{
    Console.WriteLine($"EvenMin={evenMin:F2},");
}

if (evenMax == -1000000000.0)
{
    Console.WriteLine("EvenMax=No");
}
else
{
    Console.WriteLine($"EvenMax={evenMax:F2}");
}