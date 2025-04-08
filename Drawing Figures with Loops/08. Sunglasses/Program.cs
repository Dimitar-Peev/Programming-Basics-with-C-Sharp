int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n * 2; i++)
{
    Console.Write("*");
}

for (int i = 0; i < n; i++)
{
    Console.Write(" ");
}

for (int i = 0; i < n * 2; i++)
{
    Console.Write("*");
}

Console.WriteLine();

for (int row = 1; row <= n - 2; row++)
{
    Console.Write("*");
    for (int i = 0; i < (n * 2) - 2; i++)
    {
        Console.Write("/");
    }
    Console.Write("*");

    if (row == (n - 1) / 2)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("|");
        }
    }
    else
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(" ");
        }
    }

    Console.Write("*");
    for (int i = 0; i < (n * 2) - 2; i++)
    {
        Console.Write("/");
    }
    Console.Write("*");

    Console.WriteLine();
}

for (int i = 0; i < n * 2; i++)
{
    Console.Write("*");
}

for (int i = 0; i < n; i++)
{
    Console.Write(" ");
}

for (int i = 0; i < n * 2; i++)
{
    Console.Write("*");
}

Console.WriteLine();