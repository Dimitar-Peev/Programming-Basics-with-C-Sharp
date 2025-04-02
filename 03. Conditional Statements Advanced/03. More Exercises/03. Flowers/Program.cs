int countChrysanthemums = int.Parse(Console.ReadLine());
int countRoses = int.Parse(Console.ReadLine());
int countTulips = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
string holiday = Console.ReadLine();

double priceChrysanthemums = 0;
double priceRoses = 0;
double priceTulips = 0;

if ("Spring".Equals(season) || "Summer".Equals(season))
{
    priceChrysanthemums = 2.00;
    priceRoses = 4.10;
    priceTulips = 2.50;
}
else if ("Autumn".Equals(season) || "Winter".Equals(season))
{
    priceChrysanthemums = 3.75;
    priceRoses = 4.50;
    priceTulips = 4.15;
}

double totalPrice = (countChrysanthemums * priceChrysanthemums)
        + (countRoses * priceRoses)
        + (countTulips * priceTulips);


if ("Y".Equals(holiday))
{
    totalPrice *= 1.15;
}

if ("Spring".Equals(season) && countTulips > 7)
{
    totalPrice *= 0.95;
}

if ("Winter".Equals(season) && countRoses >= 10)
{
    totalPrice *= 0.90;
}

double countFlowers = countChrysanthemums + countTulips + countRoses;

if (countFlowers > 20)
{
    totalPrice *= 0.80;
}
else
{
    totalPrice *= 1;
}

Console.WriteLine($"{(totalPrice + 2):F2}");