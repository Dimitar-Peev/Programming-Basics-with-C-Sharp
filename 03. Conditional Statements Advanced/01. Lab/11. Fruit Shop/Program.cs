string fruit = Console.ReadLine();
string dayOfWeek = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

bool isWorkingDay = dayOfWeek.Equals("Monday")
        || dayOfWeek.Equals("Tuesday")
        || dayOfWeek.Equals("Wednesday")
        || dayOfWeek.Equals("Thursday")
        || dayOfWeek.Equals("Friday");

bool isWeekend = dayOfWeek.Equals("Saturday")
        || dayOfWeek.Equals("Sunday");

bool isValid = true;

double price = 0;
if (isWorkingDay)
{
    if (fruit.Equals("banana"))
    {
        price = 2.5;
    }
    else if (fruit.Equals("apple"))
    {
        price = 1.2;
    }
    else if (fruit.Equals("orange"))
    {
        price = 0.85;
    }
    else if (fruit.Equals("grapefruit"))
    {
        price = 1.45;
    }
    else if (fruit.Equals("kiwi"))
    {
        price = 2.7;
    }
    else if (fruit.Equals("pineapple"))
    {
        price = 5.5;
    }
    else if (fruit.Equals("grapes"))
    {
        price = 3.85;
    }
    else
    {
        isValid = false;
    }
}
else if (isWeekend)
{
    if (fruit.Equals("banana"))
    {
        price = 2.7;
    }
    else if (fruit.Equals("apple"))
    {
        price = 1.25;
    }
    else if (fruit.Equals("orange"))
    {
        price = 0.90;
    }
    else if (fruit.Equals("grapefruit"))
    {
        price = 1.6;
    }
    else if (fruit.Equals("kiwi"))
    {
        price = 3;
    }
    else if (fruit.Equals("pineapple"))
    {
        price = 5.6;
    }
    else if (fruit.Equals("grapes"))
    {
        price = 4.2;
    }
    else
    {
        isValid = false;
    }
}
else
{
    isValid = false;
}

if (isValid)
{
    double result = quantity * price;
    Console.WriteLine($"{result:F2}");
}
else
{
    Console.WriteLine("error");
}