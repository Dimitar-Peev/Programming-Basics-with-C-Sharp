int limit = int.Parse(Console.ReadLine());

int sum = 0;
while (sum < limit)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sum += currentNumber;
}

Console.WriteLine(sum);