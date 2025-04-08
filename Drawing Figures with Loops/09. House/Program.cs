int n = int.Parse(Console.ReadLine());

int dashesEven = (n - 2) / 2;
int dashesOdd = (n - 1) / 2;
int starsEven = 1;
int starsOdd = 1;

int roof = (n + 1) / 2;

for (int rowRoof = 1; rowRoof <= roof; rowRoof++)
{
    if (n % 2 == 0)
    {
        for (int i = 0; i < dashesEven; i++)
        {
            Console.Write("-");
        }

        for (int i = 0; i < starsEven * 2; i++)
        {
            Console.Write("*");
        }

        for (int i = 0; i < dashesEven; i++)
        {
            Console.Write("-");
        }

        Console.WriteLine();
        dashesEven--;
        starsEven++;
    }
    else
    {
        for (int i = 0; i < dashesOdd; i++)
        {
            Console.Write("-");
        }

        for (int i = 0; i < starsOdd; i++)
        {
            Console.Write("*");
        }

        for (int i = 0; i < dashesOdd; i++)
        {
            Console.Write("-");
        }

        Console.WriteLine();
        starsOdd += 2;
        dashesOdd--;
    }
}

int baseHeight = n / 2;

for (int rowBase = 1; rowBase <= baseHeight; rowBase++)
{
    Console.Write("|");
    for (int i = 0; i < n - 2; i++)
    {
        Console.Write("*");
    }

    Console.WriteLine("|");
}