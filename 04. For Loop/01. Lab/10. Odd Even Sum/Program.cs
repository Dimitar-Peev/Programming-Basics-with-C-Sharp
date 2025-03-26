int n = int.Parse(Console.ReadLine());

int oddSum = 0;
int evenSum = 0;

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        evenSum += int.Parse(Console.ReadLine());

    }
    else
    {
        oddSum += int.Parse(Console.ReadLine());

    }
}

if (evenSum == oddSum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {evenSum}");
}
else
{
    int diff = Math.Abs(evenSum - oddSum);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {diff}");
}