int magnolias = int.Parse(Console.ReadLine());
int hyacinths = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int cacti = int.Parse(Console.ReadLine());
double giftPrice = double.Parse(Console.ReadLine());

double profit = ((magnolias * 3.25) + (hyacinths * 4) + (roses * 3.5) + (cacti * 8)) * 0.95;

if (profit >= giftPrice)
{
    Console.WriteLine($"She is left with {Math.Floor(profit - giftPrice):F0} leva.");
}
else
{
    Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - profit):F0} leva.");
}