
int bottles = int.Parse(Console.ReadLine());
int totalDetergent = bottles * 750; // Общо количество препарат в мл

int cycleCount = 0;
int totalDishes = 0;
int totalPots = 0;

string input;
while ((input = Console.ReadLine()) != "End")
{
    int items = int.Parse(input);
    cycleCount++;

    int detergentNeeded = 0;

    if (cycleCount % 3 == 0)
    {
        detergentNeeded = items * 15;
        totalPots += items;
    }
    else
    {
        detergentNeeded = items * 5;
        totalDishes += items;
    }

    totalDetergent -= detergentNeeded;

    if (totalDetergent < 0)
    {
        Console.WriteLine($"Not enough detergent, {Math.Abs(totalDetergent)} ml. more necessary!");
        return;
    }
}

Console.WriteLine("Detergent was enough!");
Console.WriteLine($"{totalDishes} dishes and {totalPots} pots were washed.");
Console.WriteLine($"Leftover detergent {totalDetergent} ml.");
