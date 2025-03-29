int kilometers = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();

double taxiStartPrice = 0.70;
double taxiDaylyRate = 0.79;
double taxiNightRate = 0.90;
double bussPrice = 0.09;
double trainPrice = 0.06;
int trainMinDistance = 100;
double price = 0.0;

if (kilometers < 20)
{
    if (dayTime.Equals("day"))
    {
        price = taxiStartPrice + (kilometers * taxiDaylyRate);
    }
    else if (dayTime.Equals("night"))
    {
        price = taxiStartPrice + (kilometers * taxiNightRate);
    }
}
else if (kilometers < trainMinDistance)
{
    price = kilometers * bussPrice;
}
else
{
    price = kilometers * trainPrice;
}

Console.WriteLine($"{price:F2}", price);