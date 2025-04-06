int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

for (int i = 2; i <= number1; i += 2)
{
    for (int j = 1; j <= number2; j++)
    {
        if (j == 2 || j == 3 || j == 5 || j == 7)
        {
            for (int k = 2; k <= number3; k += 2)
            {
                Console.WriteLine($"{i} {j} {k}");
            }
        }
    }
}