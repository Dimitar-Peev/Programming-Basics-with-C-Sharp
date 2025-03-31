double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

double price = 0;
string destination = "";

if (budget <= 100)
{
    destination = "Bulgaria";
    if ("summer".Equals(season))
    {
        price = budget * 0.3;
    }
    else if ("winter".Equals(season))
    {
        price = budget * 0.7;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    if ("summer".Equals(season))
    {
        price = budget * 0.4;
    }
    else if ("winter".Equals(season))
    {
        price = budget * 0.8;
    }
}
else if (budget > 1000)
{
    destination = "Europe";
    price = budget * 0.9;
}

string type = "";

if ("winter".Equals(season) || destination.Equals("Europe"))
{
    type = "Hotel";
}
else
{
    type = "Camp";
}
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{type} - {price:F2}");