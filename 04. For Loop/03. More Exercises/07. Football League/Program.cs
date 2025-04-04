int capacity = int.Parse(Console.ReadLine());
int allPeople = int.Parse(Console.ReadLine());

int sectorA = 0;
int sectorB = 0;
int sectorV = 0;
int sectorG = 0;

for (int i = 0; i < allPeople; i++)
{
    string sector = Console.ReadLine();

    if (sector == "A")
    {
        sectorA++;
    }
    else if (sector == "B")
    {
        sectorB++;
    }
    else if (sector == "V")
    {
        sectorV++;
    }
    else if (sector == "G")
    {
        sectorG++;
    }
}

double sectorAPercent = (100.0 / allPeople) * sectorA;
Console.WriteLine($"{sectorAPercent:F2}%");

double sectorBPercent = (100.0 / allPeople) * sectorB;
Console.WriteLine($"{sectorBPercent:F2}%");

double sectorVPercent = (100.0 / allPeople) * sectorV;
Console.WriteLine($"{sectorVPercent:F2}%");

double sectorGPercent = (100.0 / allPeople) * sectorG;
Console.WriteLine($"{sectorGPercent:F2}%");

double totalPercent = (allPeople * 1.0 / capacity) * 100;
Console.WriteLine($"{totalPercent:F2}%");
