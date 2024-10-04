double mackerelPricePerKg = double.Parse(Console.ReadLine());
double sprinklePricePerKg = double.Parse(Console.ReadLine());
double bonitoKg = double.Parse(Console.ReadLine());
double safridKg = double.Parse(Console.ReadLine());
int mussels = int.Parse(Console.ReadLine());

double bonitoPriceKg = (mackerelPricePerKg * 1.6) * bonitoKg;
double safridPriceKg = (sprinklePricePerKg * 1.8) * safridKg;
double musselsPriceKg = mussels * 7.5;

double totalSum = bonitoPriceKg + safridPriceKg + musselsPriceKg;

Console.WriteLine($"{totalSum:F2}");