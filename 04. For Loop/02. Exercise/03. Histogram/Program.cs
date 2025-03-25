int allNumbersCount = int.Parse(Console.ReadLine());

int p1NumbersCount = 0;
int p2NumbersCount = 0;
int p3NumbersCount = 0;
int p4NumbersCount = 0;
int p5NumbersCount = 0;

for (int i = 1; i <= allNumbersCount; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber < 200)
    {
        p1NumbersCount++;
    }
    else if (currentNumber < 400)
    {
        p2NumbersCount++;
    }
    else if (currentNumber < 600)
    {
        p3NumbersCount++;
    }
    else if (currentNumber < 800)
    {
        p4NumbersCount++;
    }
    else 
    {
        p5NumbersCount++;
    }
}

double p1NumbersPercent = ((p1NumbersCount * 1.0) / allNumbersCount) * 100;
double p2NumbersPercent = ((p2NumbersCount * 1.0) / allNumbersCount) * 100;
double p3NumbersPercent = ((p3NumbersCount * 1.0) / allNumbersCount) * 100;
double p4NumbersPercent = ((p4NumbersCount * 1.0) / allNumbersCount) * 100;
double p5NumbersPercent = ((p5NumbersCount * 1.0) / allNumbersCount) * 100;

Console.WriteLine($"{p1NumbersPercent:f2}%");
Console.WriteLine($"{p2NumbersPercent:f2}%");
Console.WriteLine($"{p3NumbersPercent:f2}%");
Console.WriteLine($"{p4NumbersPercent:f2}%");
Console.WriteLine($"{p5NumbersPercent:f2}%");