double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string carClass = "";
string carType = "";
double carPrice = 0;

if (budget <= 100)
{
    carClass = "Economy class";
    switch (season)
    {
        case "Summer":
            carType = "Cabrio";
            carPrice = budget * 0.35;
            break;
        case "Winter":
            carType = "Jeep";
            carPrice = budget * 0.65;
            break;
    }

}
else if (budget <= 500)
{
    carClass = "Compact class";
    switch (season)
    {
        case "Summer":
            carType = "Cabrio";
            carPrice = budget * 0.45;
            break;
        case "Winter":
            carType = "Jeep";
            carPrice = budget * 0.80;
            break;
    }
}
else
{
    carClass = "Luxury class";
    carType = "Jeep";
    carPrice = budget * 0.9;
}


Console.WriteLine(carClass);
Console.WriteLine($"{carType} - {carPrice:F2}");