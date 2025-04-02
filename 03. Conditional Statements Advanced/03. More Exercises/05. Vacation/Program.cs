double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string location = "";
string place = "";
double price = 0;

if (budget <= 1000)
{
    location = "Camp";
    switch (season)
    {
        case "Summer":
            place = "Alaska";
            price = budget * 0.65;
            break;
        case "Winter":
            place = "Morocco";
            price = budget * 0.45;
            break;
    }
}
else if (budget <= 3000)
{
    location = "Hut";
    switch (season)
    {
        case "Summer":
            place = "Alaska";
            price = budget * 0.8;
            break;
        case "Winter":
            place = "Morocco";
            price = budget * 0.6;
            break;
    }
}
else if (budget > 3000)
{
    location = "Hotel";
    switch (season)
    {
        case "Summer":
            place = "Alaska";
            price = budget * 0.9;
            break;
        case "Winter":
            place = "Morocco";
            price = budget * 0.9;
            break;
    }
}

Console.WriteLine($"{place} - {location} - {price:F2}");