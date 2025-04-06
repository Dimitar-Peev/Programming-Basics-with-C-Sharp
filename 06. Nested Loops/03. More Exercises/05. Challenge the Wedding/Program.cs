int menCount = int.Parse(Console.ReadLine());
int womenCount = int.Parse(Console.ReadLine());
int maxTables = int.Parse(Console.ReadLine());

int tablesUsed = 0;

for (int man = 1; man <= menCount; man++)
{
    for (int woman = 1; woman <= womenCount; woman++)
    {
        Console.Write($"({man} <-> {woman}) ");
        tablesUsed++;

        if (tablesUsed >= maxTables)
        {
            return;
        }
    }
}