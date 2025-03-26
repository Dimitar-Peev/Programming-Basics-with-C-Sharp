int n = int.Parse(Console.ReadLine());

int maxNum = 0;
int minNum = 0;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num > maxNum)
    {
        maxNum = num;

    }

    if (num < minNum)
    {
        minNum = num;

    }
}

Console.WriteLine($"Max number: {maxNum}");
Console.WriteLine($"Min number: {minNum}");