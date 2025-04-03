double money = double.Parse(Console.ReadLine());
int year = int.Parse(Console.ReadLine());

int age = 18;
int diff = year - 1800;

for (int i = 0; i <= diff; i++)
{
    if (i % 2 == 0)
    {
        money -= 12000;
    }
    else
    {
        money = money - (12000 + (50 * age));
    }

    age++;
}

if (money >= 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {money:F2} dollars left.");
}
else
{
    Console.WriteLine($"He will need {Math.Abs(money):F2} dollars to survive.");
}