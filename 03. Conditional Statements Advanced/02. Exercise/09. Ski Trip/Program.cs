
int dayStay = int.Parse(Console.ReadLine());
string tipeRoom = Console.ReadLine();
string review = Console.ReadLine();

double totalPrice = 0.00;

switch (tipeRoom)
{
    case "room for one person":
        totalPrice = (dayStay - 1) * 18.00;
        break;
    case "apartment":
        totalPrice = (dayStay - 1) * 25.00;
        if (dayStay < 10)
        {
            totalPrice = totalPrice - (totalPrice * 0.30);
        }
        else if (dayStay >= 10 && dayStay <= 15)
        {
            totalPrice = totalPrice - (totalPrice * 0.35);
        }
        else totalPrice = totalPrice - (totalPrice * 0.50);
        break;
    case "president apartment":
        totalPrice = (dayStay - 1) * 35.00;
        if (dayStay < 10)
        {
            totalPrice = totalPrice - (totalPrice * 0.10);
        }
        else if (dayStay >= 10 && dayStay <= 15)
        {
            totalPrice = totalPrice - (totalPrice * 0.15);
        }
        else totalPrice = totalPrice - (totalPrice * 0.20);
        break;
}

if ("positive".Equals(review))
{
    totalPrice = totalPrice + (totalPrice * 0.25);
}
else if ("negative".Equals(review))
{
    totalPrice = totalPrice - (totalPrice * 0.10);
}

Console.WriteLine($"{totalPrice:F2}");