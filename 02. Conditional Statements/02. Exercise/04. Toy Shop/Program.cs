double excursion = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

int numberOfToys = puzzles + dolls + bears + minions + trucks;
double priceForPuzzles = puzzles * 2.60;
double priceForDolls = dolls * 3.00;
double priceForBears = bears * 4.10;
double priceForMinions = minions * 8.20;
double priceForTrucks = trucks * 2.00;
double sumTotal = priceForPuzzles + priceForDolls + priceForBears + priceForMinions + priceForTrucks;
sumTotal = sumTotal - (sumTotal * 0.1);

if (numberOfToys >= 50)
{
    sumTotal = sumTotal * 0.75;
}

double difference = Math.Abs(sumTotal - excursion);

if (sumTotal >= excursion)
{
    Console.WriteLine($"Yes! {difference:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {difference:F2} lv needed.");
}