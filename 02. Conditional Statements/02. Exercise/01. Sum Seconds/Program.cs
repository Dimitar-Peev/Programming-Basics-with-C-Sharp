﻿int timeFirst = int.Parse(Console.ReadLine());
int timeSecond = int.Parse(Console.ReadLine());
int timeThird = int.Parse(Console.ReadLine());

int totalTime = timeFirst + timeSecond + timeThird;
int minutes = totalTime / 60;
int seconds = totalTime % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}