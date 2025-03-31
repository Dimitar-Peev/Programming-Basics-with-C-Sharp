int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermen = int.Parse(Console.ReadLine());

double shipPrice = 0.0;

switch (season)
{
    case "Spring":
        shipPrice = 3000;
        break;
    case "Summer":
    case "Autumn":
        shipPrice = 4200;
        break;
    case "Winter":
        shipPrice = 2600;
        break;
}

if (fishermen <= 6)
{
    shipPrice = shipPrice * 0.9;
}
else if (fishermen <= 11)
{
    shipPrice = shipPrice * 0.85;
}
else
{
    shipPrice = shipPrice * 0.75;
}

if (fishermen % 2 == 0 && !"Autumn".Equals(season))
{
    shipPrice = shipPrice * 0.95;
}

if (budget >= shipPrice)
{
    double moneyLeft = budget - shipPrice;
    Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
}
else
{
    double neededMoney = shipPrice - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
}