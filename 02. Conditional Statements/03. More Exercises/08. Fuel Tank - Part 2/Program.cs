string fuelType = Console.ReadLine();
int fuelQuantity = int.Parse(Console.ReadLine());
string clubCard = Console.ReadLine();

double fuelPrice = 0;

switch (fuelType)
{
    case "Gas":
        if (clubCard.Equals("Yes"))
        {
            fuelPrice = 0.93 - 0.08;
        }
        else if (clubCard.Equals("No"))
        {
            fuelPrice = 0.93;
        }
        break;
    case "Gasoline":
        if (clubCard.Equals("Yes"))
        {
            fuelPrice = 2.22 - 0.18;
        }
        else if (clubCard.Equals("No"))
        {
            fuelPrice = 2.22;
        }
        break;
    case "Diesel":
        if (clubCard.Equals("Yes"))
        {
            fuelPrice = 2.33 - 0.12;
        }
        else if (clubCard.Equals("No"))
        {
            fuelPrice = 2.33;
        }
        break;
}

double totalPrice = fuelPrice * fuelQuantity;

if (fuelQuantity >= 20 && fuelQuantity <= 25)
{
    totalPrice = totalPrice * 0.92;
}
else if (fuelQuantity > 25)
{
    totalPrice = totalPrice * 0.9;
}


Console.WriteLine($"{totalPrice:F2} lv.");

