int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int cakePieces = width * length;
string breakCommand = "STOP";

string input = Console.ReadLine();

while (breakCommand != input)
{
    int currentPieces = int.Parse(input);
    cakePieces -= currentPieces;

    if (cakePieces <= 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
        break;
    }

    input = Console.ReadLine();
}

if (cakePieces > 0)
{
    Console.WriteLine($"{cakePieces} pieces are left.");
}