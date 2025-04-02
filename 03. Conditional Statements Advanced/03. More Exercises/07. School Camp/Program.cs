string season = Console.ReadLine();
string groupType = Console.ReadLine();
int countStudents = int.Parse(Console.ReadLine());
int countOvernight = int.Parse(Console.ReadLine());

string sportType = "";
double pricePerNight = 0;

switch (season)
{
    case "Winter":
        if (groupType == ("boys"))
        {
            pricePerNight = 9.6;
            sportType = "Judo";
        }
        else if (groupType == ("girls"))
        {
            pricePerNight = 9.6;
            sportType = "Gymnastics";
        }
        else if (groupType == ("mixed"))
        {
            pricePerNight = 10;
            sportType = "Ski";
        }
        break;
    case "Spring":
        if (groupType == ("boys"))
        {
            pricePerNight = 7.2;
            sportType = "Tennis";
        }
        else if (groupType == ("girls"))
        {
            pricePerNight = 7.2;
            sportType = "Athletics";
        }
        else if (groupType == ("mixed"))
        {
            pricePerNight = 9.5;
            sportType = "Cycling";
        }
        break;
    case "Summer":
        if (groupType == ("boys"))
        {
            pricePerNight = 15;
            sportType = "Football";
        }
        else if (groupType == ("girls"))
        {
            pricePerNight = 15;
            sportType = "Volleyball";
        }
        else if (groupType == ("mixed"))
        {
            pricePerNight = 20;
            sportType = "Swimming";
        }
        break;

}

double totalPrice = countStudents * pricePerNight * countOvernight;

if (countStudents >= 10 && countStudents < 20)
{
    totalPrice *= 0.95;
}
else if (countStudents >= 20 && countStudents < 50)
{
    totalPrice *= 0.85;
}
else if (countStudents >= 50)
{
    totalPrice *= 0.5;
}
else
{
    totalPrice *= 1;
}

Console.WriteLine($"{sportType} {totalPrice:F2} lv.");