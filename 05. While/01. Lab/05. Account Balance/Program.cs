double amount = 0;

string input = Console.ReadLine();
while ("NoMoreMoney" != input)
{
    double number = double.Parse(input);

    if (number < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    amount += number;
    Console.WriteLine($"Increase: {number:f2}");
    input = Console.ReadLine();
}

Console.WriteLine($"Total: {amount:f2}");