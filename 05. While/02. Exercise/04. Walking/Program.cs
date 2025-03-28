int stepsCount = 0;
int stepsGoal = 10000;
string breakCommand = "Going home";

while (stepsCount < stepsGoal)
{
    string input = Console.ReadLine();

    if (input == breakCommand)
    {
        int stepsToHome = int.Parse(Console.ReadLine());
        stepsCount += stepsToHome;
        break;
    }

    int currentSteps = int.Parse(input);
    stepsCount += currentSteps;
}

int diffSteps = Math.Abs(stepsCount - stepsGoal);
if (stepsCount >= stepsGoal)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{diffSteps} steps over the goal!");
}
else
{
    Console.WriteLine($"{diffSteps} more steps to reach goal.");
}