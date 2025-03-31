int celsius = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();

string outfit = "";
string shoes = "";

if (10 <= celsius && celsius <= 18)
{
    switch (dayTime)
    {
        case "Morning":
            outfit = "Sweatshirt";
            shoes = "Sneakers";
            break;
        case "Afternoon":
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
    }
}
else if (18 < celsius && celsius <= 24)
{
    switch (dayTime)
    {
        case "Morning":
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
        case "Afternoon":
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
    }
}
else if (celsius >= 25)
{
    switch (dayTime)
    {
        case "Morning":
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
        case "Afternoon":
            outfit = "Swim Suit";
            shoes = "Barefoot";
            break;
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
    }
}

Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");