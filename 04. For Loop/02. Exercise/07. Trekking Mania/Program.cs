int groupsCount = int.Parse(Console.ReadLine());

int totalPeople = 0;

int peopleMusala = 0;
int peopleMonblan = 0;
int peopleKilimandzharo = 0;
int peopleK2 = 0;
int peopleEverest = 0;

for (int i = 0; i < groupsCount; i++)
{
    int currentPeopleCount = int.Parse(Console.ReadLine());
    totalPeople += currentPeopleCount;

    if (currentPeopleCount <= 5)
    {
        peopleMusala += currentPeopleCount;
    }
    else if (currentPeopleCount <= 12)
    {
        peopleMonblan += currentPeopleCount;
    }
    else if (currentPeopleCount <= 25)
    {
        peopleKilimandzharo += currentPeopleCount;
    }
    else if (currentPeopleCount <= 40)
    {
        peopleK2 += currentPeopleCount;
    }
    else
    {
        peopleEverest += currentPeopleCount;
    }
}

double percentMusala = peopleMusala * 100.0 / totalPeople;
double percentMonblan = peopleMonblan * 100.0 / totalPeople;
double percentKilimandzharo = peopleKilimandzharo * 100.0 / totalPeople;
double percentK2 = peopleK2 * 100.0 / totalPeople;
double percentEverest = peopleEverest * 100.0 / totalPeople;

Console.WriteLine($"{percentMusala:f2}%");
Console.WriteLine($"{percentMonblan:f2}%");
Console.WriteLine($"{percentKilimandzharo:f2}%");
Console.WriteLine($"{percentK2:f2}%");
Console.WriteLine($"{percentEverest:f2}%");