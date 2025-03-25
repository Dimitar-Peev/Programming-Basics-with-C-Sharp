string actorName = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int numOfJudges = int.Parse(Console.ReadLine());

double pointsForNomination = 1250.5;

for (int i = 0; i < numOfJudges; i++)
{
    string currentJudgeName = Console.ReadLine();
    double currentJudgePoints = double.Parse(Console.ReadLine());

    points += (currentJudgeName.Length * currentJudgePoints) / 2;

    if (points > pointsForNomination)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
        break;
    }
}

if (points <= pointsForNomination)
{
    double neededPoints = pointsForNomination - points;
    Console.WriteLine($"Sorry, {actorName} you need {neededPoints:f1} more!");
}