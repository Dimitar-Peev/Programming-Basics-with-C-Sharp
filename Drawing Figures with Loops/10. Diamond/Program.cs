int n = int.Parse(Console.ReadLine());

int dashesOut = (n - 1) / 2;
int dashesIn = n - 4;

if (n % 2 == 0)
{

    for (int row = 0; row < n / 2; row++)
    {
        for (int i = 0; i < dashesOut; i++)
        {
            Console.Write("-");
        }
        Console.Write("*");
        for (int i = 0; i < 2 * row; i++)
        {
            Console.Write("-");
        }
        Console.Write("*");
        for (int i = 0; i < dashesOut; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        dashesOut--;
    }

    dashesOut = 1;

    for (int row = 0; row < (n / 2) - 1; row++)
    {
        for (int i = 0; i < dashesOut; i++)
        {
            Console.Write("-");
        }
        Console.Write("*");
        for (int i = 0; i < dashesIn; i++)
        {
            Console.Write("-");
        }
        Console.Write("*");
        for (int i = 0; i < dashesOut; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        dashesIn -= 2;
        dashesOut++;
    }
}
else
{

    int starsTwo = 1;

    if (n == 1)
    {
        Console.WriteLine("*");
        return;
    }
    else
    {
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.Write("-");
        }
        for (int i = 0; i < starsTwo; i++)
        {
            Console.Write("*");
        }
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }

    dashesOut = (n - 1) / 2;
    for (int row = 0; row < n / 2; row++)
    {
        for (int i = 0; i < dashesOut - 1; i++)
        {
            Console.Write("-");
        }
        Console.Write("*");
        for (int i = 0; i < 2 * row + 1; i++)
        {
            Console.Write("-");
        }
        Console.Write("*");
        for (int i = 0; i < dashesOut - 1; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        dashesOut--;
    }

    dashesIn = n - 4;
    for (int row = 0; row < n / 2 - 1; row++)
    {
        for (int i = 0; i < row + 1; i++)
        {
            Console.Write("-");
        }
        Console.Write("*");
        for (int i = 0; i < dashesIn; i++)
        {
            Console.Write("-");
        }
        Console.Write("*");
        for (int i = 0; i < row + 1; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        dashesIn -= 2;
    }

    for (int i = 0; i < (n - 1) / 2; i++)
    {
        Console.Write("-");
    }
    Console.Write("*");
    for (int i = 0; i < (n - 1) / 2; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
}