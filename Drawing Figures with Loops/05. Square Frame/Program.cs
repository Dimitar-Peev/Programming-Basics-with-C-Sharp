int n = int.Parse(Console.ReadLine());

Console.Write("+ ");
for (int dashes = 1; dashes <= n - 2; dashes++)
{
    Console.Write("- ");
}
Console.WriteLine("+");

for (int row = 1; row <= n - 2; row++)
{
    Console.Write("| ");
    for (int dashes = 1; dashes <= n - 2; dashes++)
    {
        Console.Write("- ");
    }
    Console.WriteLine("|");
}
Console.Write("+ ");

for (int dashes = 1; dashes <= n - 2; dashes++)
{
    Console.Write("- ");
}
Console.WriteLine("+");