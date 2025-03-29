int restDays = int.Parse(Console.ReadLine());

int gameMinutesPerYear = 30000;
int minutesForGameInWorkingDay = 63;
int minutesForGameInDayOff = 127;

int workingDays = 365 - restDays;
int realGameMinutes = workingDays * minutesForGameInWorkingDay + restDays * minutesForGameInDayOff;
int hours = Math.Abs(gameMinutesPerYear - realGameMinutes) / 60;
int minutes = Math.Abs(gameMinutesPerYear - realGameMinutes) % 60;

if (realGameMinutes > gameMinutesPerYear)
{
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
}
else
{
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
}