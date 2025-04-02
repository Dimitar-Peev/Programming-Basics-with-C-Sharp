double budget = int.Parse(Console.ReadLine());
string category = Console.ReadLine();
int people = int.Parse(Console.ReadLine());

double restSum = 0;

if (people <= 4)
{
    restSum = budget - (budget * 0.75);
}
else if (people <= 9)
{
    restSum = budget - (budget * 0.6);
}
else if (people <= 24)
{
    restSum = budget - (budget * 0.5);
}
else if (people <= 49)
{
    restSum = budget - (budget * 0.4);
}
else
{
    restSum = budget - (budget * 0.25);
}

switch (category)
{
    case "VIP":
        restSum -= 499.99 * people;
        break;
    case "Normal":
        restSum -= 249.99 * people;
        break;
}

if (restSum > 0)
{
    Console.WriteLine($"Yes! You have {restSum:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(restSum):F2} leva.");
}
