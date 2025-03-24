double recordsInSeconds = double.Parse(Console.ReadLine());
double metersToSwim = double.Parse(Console.ReadLine());
double secondsForOneMeterSwim = double.Parse(Console.ReadLine());

double swimSecondsWithoutDelay = metersToSwim * secondsForOneMeterSwim;
double delayTimes = Math.Floor(metersToSwim / 15);

double swimSeconds = swimSecondsWithoutDelay + (delayTimes * 12.5);

if (swimSeconds < recordsInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {swimSeconds:F2} seconds.");
}
else
{
    double neededSeconds = swimSeconds - recordsInSeconds;
    Console.WriteLine($"No, he failed! He was {neededSeconds:F2} seconds slower.");
}