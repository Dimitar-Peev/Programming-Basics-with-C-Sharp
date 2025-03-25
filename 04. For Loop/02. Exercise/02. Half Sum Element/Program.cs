int n = int.Parse(Console.ReadLine());

int sum = 0;
int maxNumber = int.MinValue;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sum += currentNumber;

    if (maxNumber < currentNumber)
    {
        maxNumber = currentNumber;
    }
}

sum -= maxNumber;

if (maxNumber == sum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    int difference = Math.Abs(maxNumber - sum);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {difference}");
}