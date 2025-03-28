int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());


int freeSpace = width * length * height;
string breakCommand = "Done";
string input = Console.ReadLine();

while (breakCommand != input && freeSpace > 0)
{
    int boxesCount = int.Parse(input);
    freeSpace -= boxesCount;

    input = Console.ReadLine();
}

if (freeSpace >= 0)
{
    Console.WriteLine($"{freeSpace} Cubic meters left.");
}
else
{
    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
}