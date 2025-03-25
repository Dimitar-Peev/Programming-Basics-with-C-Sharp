int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

int toysCount = 0;
int totalSum = 0;
int moneyIntake = 0;

for (int currentAge = 1; currentAge <= age; currentAge++)
{
    if (currentAge % 2 == 1)
    {
        toysCount++;
    }
    else
    {
        moneyIntake += 10;
        totalSum += moneyIntake;
        totalSum--;
    }
}

totalSum += toysCount * toyPrice;

double diff = Math.Abs(totalSum - washingMachinePrice);
if (totalSum >= washingMachinePrice)
{
    double remainingMoney = totalSum - washingMachinePrice;
    Console.WriteLine($"Yes! {diff:f2}");
}
else
{
    double remainingMoney = washingMachinePrice - totalSum;
    Console.WriteLine($"No! {diff:f2}");
}