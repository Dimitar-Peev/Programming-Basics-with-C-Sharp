double meters = double.Parse(Console.ReadLine());

double pricePerMeter = 7.61;

double sum = meters * pricePerMeter;

double totalSum = sum * 0.82;
double discount = sum * 0.18;

Console.WriteLine($"The final price is: {totalSum:F2} lv.");
Console.WriteLine($"The discount is: {discount:F2} lv.");