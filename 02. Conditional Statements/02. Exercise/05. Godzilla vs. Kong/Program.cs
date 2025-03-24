double budget = double.Parse(Console.ReadLine());
int numOfPeople = int.Parse(Console.ReadLine());
double pricePerPerson = double.Parse(Console.ReadLine());

double decor = budget * 0.1;
double costumerPrice = pricePerPerson * numOfPeople;

if (numOfPeople > 150)
{
    costumerPrice = costumerPrice - costumerPrice * 0.1;
}

double result = decor + costumerPrice;
double diff = Math.Abs(budget - result);

if (budget >= result)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {diff:F2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {diff:F2} leva more.", diff);
}