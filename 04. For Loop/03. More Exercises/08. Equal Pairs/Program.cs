int n = int.Parse(Console.ReadLine());

int firstSum = 0;
int secondSum = 0;
int diff = 0;

for (int i = 1; i <= n; i++)
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());

    if (i % 2 != 0)
    {
        firstSum = n1 + n2;
    }
    else
    {
        secondSum = n1 + n2;
    }

}

diff = Math.Abs(firstSum - secondSum);

if (firstSum == secondSum || n < 2)
{
    Console.WriteLine($"Yes, value={firstSum}");
}
else
{
    Console.WriteLine($"No, maxdiff={diff}");
}