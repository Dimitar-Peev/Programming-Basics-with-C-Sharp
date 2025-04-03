int n = int.Parse(Console.ReadLine());

double totalTons = 0;

double tonVan = 0;
double tonTruck = 0;
double tonTrain = 0;

for (int i = 0; i < n; i++)
{
    int ton = int.Parse(Console.ReadLine());
    totalTons += ton;

    if (ton <= 3)
    {
        tonVan += ton;
    }
    else if (ton <= 11)
    {
        tonTruck += ton;
    }
    else
    {
        tonTrain += ton;
    }

}

double averagePrice = ((tonVan * 200) + (tonTruck * 175) + (tonTrain * 120)) / totalTons;
Console.WriteLine($"{averagePrice:F2}", averagePrice);

double tonVanPercent = (tonVan / totalTons) * 100;
Console.WriteLine($"{tonVanPercent:F2}%");

double tonTruckPercent = (tonTruck / totalTons) * 100;
Console.WriteLine($"{tonTruckPercent:F2}%");

double tonTrainPercent = (tonTrain / totalTons) * 100;
Console.WriteLine($"{tonTrainPercent:F2}%");