double budget = double.Parse(Console.ReadLine());
int videoCardsCount = int.Parse(Console.ReadLine());
int processorsCount = int.Parse(Console.ReadLine());
int ramsCount = int.Parse(Console.ReadLine());

double videocardsBill = videoCardsCount * 250;
double processorsBill = processorsCount * (videocardsBill * 0.35);
double ramsBill = ramsCount * (videocardsBill * 0.1);

double bill = videocardsBill + processorsBill + ramsBill;

if (videoCardsCount > processorsCount)
{
    bill *= 0.85;
}

if (budget >= bill)
{
    double moneyLeft = budget - bill;
    Console.WriteLine($"You have {moneyLeft:F2} leva left!");
}
else
{
    double neededMoney = bill - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
}
