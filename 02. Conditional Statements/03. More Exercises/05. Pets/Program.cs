int days = int.Parse(Console.ReadLine());
int foodInKg = int.Parse(Console.ReadLine());
double dogFoodKg = double.Parse(Console.ReadLine());
double catFoodKg = double.Parse(Console.ReadLine());
double turtleFoodGrams = double.Parse(Console.ReadLine());

double neededFood = (days * dogFoodKg) + (days * catFoodKg) + (days * turtleFoodGrams / 1000);

if (foodInKg >= neededFood)
{
    Console.WriteLine($"{Math.Floor(foodInKg - neededFood):F0} kilos of food left.");
}
else
{
    Console.WriteLine($"{Math.Ceiling(neededFood - foodInKg):F0} more kilos of food are needed.");
}