string destination = Console.ReadLine();

while (!"End".Equals(destination))
{
    double budget = double.Parse(Console.ReadLine());
    double money = 0;

    while (money < budget)
    {
        money += double.Parse(Console.ReadLine());
    }
    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}