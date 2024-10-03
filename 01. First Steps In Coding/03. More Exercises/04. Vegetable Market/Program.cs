double priceForKgVegetables = double.Parse(Console.ReadLine());
double priceForKgFruits = double.Parse(Console.ReadLine());
int sumForKgVegetables = int.Parse(Console.ReadLine());
int sumForKgFruits = int.Parse(Console.ReadLine());

double kgVegetables = priceForKgVegetables * sumForKgVegetables;
double kgFruits = priceForKgFruits * sumForKgFruits;
double sum = kgVegetables + kgFruits;
double euro = sum * 0.5154639175;

Console.WriteLine($"{euro:F2}");