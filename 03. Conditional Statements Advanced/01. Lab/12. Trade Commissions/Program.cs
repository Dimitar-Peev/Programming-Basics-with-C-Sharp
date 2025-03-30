string town = Console.ReadLine();
double income = double.Parse(Console.ReadLine());

bool isValidData = true;
double commission = 0;

if (town.Equals("Sofia"))
{
    if (income >= 0 && income <= 500)
    {
        commission = income * 0.05;
    }
    else if (income > 500 && income <= 1000)
    {
        commission = income * 0.07;
    }
    else if (income > 1000 && income <= 10000)
    {
        commission = income * 0.08;
    }
    else if (income > 10000)
    {
        commission = income * 0.12;
    }
    else
    {
        isValidData = false;
    }
}
else if (town.Equals("Varna"))
{
    if (income >= 0 && income <= 500)
    {
        commission = income * 0.045;
    }
    else if (income > 500 && income <= 1000)
    {
        commission = income * 0.075;
    }
    else if (income > 1000 && income <= 10000)
    {
        commission = income * 0.1;
    }
    else if (income > 10000)
    {
        commission = income * 0.13;
    }
    else
    {
        isValidData = false;
    }
}
else if (town.Equals("Plovdiv"))
{
    if (income >= 0 && income <= 500)
    {
        commission = income * 0.055;
    }
    else if (income > 500 && income <= 1000)
    {
        commission = income * 0.08;
    }
    else if (income > 1000 && income <= 10000)
    {
        commission = income * 0.12;
    }
    else if (income > 10000)
    {
        commission = income * 0.145;
    }
    else
    {
        isValidData = false;
    }
}
else
{
    isValidData = false;
}

if (isValidData)
{
    Console.WriteLine($"{commission:F2}");
}
else
{
    Console.WriteLine("error");
}