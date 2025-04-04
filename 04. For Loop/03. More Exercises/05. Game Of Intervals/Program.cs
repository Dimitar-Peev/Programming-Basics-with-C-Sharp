int allNumbers = int.Parse(Console.ReadLine());

double result = 0;
int invalidNumber = 0;
int numberTo9 = 0;
int numberTo19 = 0;
int numberTo29 = 0;
int numberTo39 = 0;
int numberTo50 = 0;

for (int i = 0; i < allNumbers; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number >= 0 && number < 10)
    {
        numberTo9++;
        result += number * 0.2;
    }
    else if (number >= 10 && number < 20)
    {
        numberTo19++;
        result += number * 0.3;
    }
    else if (number >= 20 && number < 30)
    {
        numberTo29++;
        result += number * 0.4;
    }
    else if (number >= 30 && number < 40)
    {
        numberTo39++;
        result += 50;
    }
    else if (number >= 40 && number <= 50)
    {
        numberTo50++;
        result += 100;
    }
    else
    {
        invalidNumber++;
        result = result / 2;
    }
}

Console.WriteLine($"{result:F2}");

double numberTo9Percent = (100.0 / allNumbers) * numberTo9;
Console.WriteLine($"From 0 to 9: {numberTo9Percent:F2}%");

double numberTo19Percent = (100.0 / allNumbers) * numberTo19;
Console.WriteLine($"From 10 to 19: {numberTo19Percent:F2}%");

double numberTo29Percent = (100.0 / allNumbers) * numberTo29;
Console.WriteLine($"From 20 to 29: {numberTo29Percent:F2}%");

double numberTo39Percent = (100.0 / allNumbers) * numberTo39;
Console.WriteLine($"From 30 to 39: {numberTo39Percent:F2}%");

double numberTo50Percent = (100.0 / allNumbers) * numberTo50;
Console.WriteLine($"From 40 to 50: {numberTo50Percent:F2}%");

double invalidPercent = (100.0 / allNumbers) * invalidNumber;
Console.WriteLine($"Invalid numbers: {invalidPercent:F2}%");