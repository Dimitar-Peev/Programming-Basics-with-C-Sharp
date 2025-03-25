int tournamentCount = int.Parse(Console.ReadLine());
int initialPoints = int.Parse(Console.ReadLine());

int points = 0;
int winsCount = 0;

for (int i = 0; i < tournamentCount; i++)
{
    string tournamentResult = Console.ReadLine();

    switch (tournamentResult)
    {
        case "W":
            points += 2000;
            winsCount++;
            break;
        case "F":
            points += 1200;
            break;
        case "SF":
            points += 720;
            break;
    }
}

int totalPoints = initialPoints + points;
double averagePoints = Math.Floor((points * 1.0) / tournamentCount);
double winPercent = winsCount * 100.0 / tournamentCount;

Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {averagePoints}");
Console.WriteLine($"{winPercent:f2}%");