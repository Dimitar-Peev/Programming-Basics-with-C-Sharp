int x = int.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
int zLitters = int.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());

double grapes = x * y;
double wine = (0.4 * grapes) / 2.5;
double diff = Math.Abs(wine - zLitters);

if (wine >= zLitters)
{
    double profitPerPerson = diff / workers;
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine):F0} liters.");
    Console.WriteLine($"{Math.Ceiling(diff):F0} liters left -> {Math.Ceiling(profitPerPerson)} liters per person.");
}
else if (wine < zLitters)
{
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(diff)} liters wine needed.");
}