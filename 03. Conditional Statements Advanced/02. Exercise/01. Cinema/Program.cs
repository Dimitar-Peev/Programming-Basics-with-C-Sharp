string projectionType = Console.ReadLine();
int rowsCount = int.Parse(Console.ReadLine());
int colsCount = int.Parse(Console.ReadLine());

double premierePrice = 12;
double normalPrice = 7.5;
double discountPrice = 5;

double income = 0;

switch (projectionType)
{
    case "Premiere":
        income = rowsCount * colsCount * premierePrice;
        break;
    case "Normal":
        income = rowsCount * colsCount * normalPrice;
        break;
    case "Discount":
        income = rowsCount * colsCount * discountPrice;
        break;
}

Console.WriteLine($"{income:F2} leva");