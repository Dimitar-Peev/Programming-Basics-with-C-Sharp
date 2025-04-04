int months = int.Parse(Console.ReadLine());

double electricityBill = 0;

for (int i = 0; i < months; i++)
{
    double electricityBillPerMonth = double.Parse(Console.ReadLine());
    electricityBill += electricityBillPerMonth;
}

Console.WriteLine($"Electricity: {electricityBill:F2} lv");

double waterBill = months * 20;
Console.WriteLine($"Water: {waterBill:F2} lv");

double internetBill = months * 15;
Console.WriteLine($"Internet: {internetBill:F2} lv");

double otherExpenses = (electricityBill + waterBill + internetBill) * 1.2;
Console.WriteLine($"Other: {otherExpenses:F2} lv");

double averageBill = (electricityBill + waterBill + internetBill + otherExpenses) / months;
Console.WriteLine($"Average: {averageBill:F2} lv");