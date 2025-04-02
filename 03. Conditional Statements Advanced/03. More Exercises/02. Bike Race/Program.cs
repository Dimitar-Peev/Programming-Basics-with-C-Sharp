int juniors = int.Parse(Console.ReadLine());
int seniors = int.Parse(Console.ReadLine());
string type = Console.ReadLine();

double juniorsTax = 0;
double seniorsTax = 0;

switch (type)
{
    case "trail":
        juniorsTax = 5.5;
        seniorsTax = 7;
        break;
    case "cross-country":
        juniorsTax = 8;
        seniorsTax = 9.5;
        break;
    case "downhill":
        juniorsTax = 12.25;
        seniorsTax = 13.75;
        break;
    case "road":
        juniorsTax = 20;
        seniorsTax = 21.5;
        break;

}

double totalPrice = (juniors * juniorsTax) + (seniors * seniorsTax);
int sumPeople = juniors + seniors;

if ("cross-country".Equals(type))
{
    if (sumPeople >= 50)
    {
        totalPrice = totalPrice * 0.75;
    }
}

double totalSum = totalPrice * 0.95;
Console.WriteLine($"{totalSum:F2}");
