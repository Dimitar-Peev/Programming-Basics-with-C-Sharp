string typeFlowers = Console.ReadLine();
int flowersCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double rosePrice = 5;
double dahliaPrice = 3.8;
double tulipsPrice = 2.8;
double narcissusPrice = 3;
double gladiolusPrice = 2.5;

double bill = 0;

switch (typeFlowers)
{
    case "Roses":
        bill = flowersCount * rosePrice;
        if (flowersCount > 80)
        {
            bill *= 0.9;
        }
        break;
    case "Dahlias":
        bill = flowersCount * dahliaPrice;
        if (flowersCount > 90)
        {
            bill *= 0.85;
        }
        break;
    case "Tulips":
        bill = flowersCount * tulipsPrice;
        if (flowersCount > 80)
        {
            bill *= 0.85;
        }
        break;
    case "Narcissus":
        bill = flowersCount * narcissusPrice;
        if (flowersCount < 120)
        {
            bill *= 1.15;
        }
        break;
    case "Gladiolus":
        bill = flowersCount * gladiolusPrice;
        if (flowersCount < 80)
        {
            bill *= 1.2;
        }
        break;
}

if (budget >= bill)
{
    double moneyLeft = budget - bill;
    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {typeFlowers} and {moneyLeft:F2} leva left.");
}
else
{
    double neededMoney = bill - budget;
    Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
}