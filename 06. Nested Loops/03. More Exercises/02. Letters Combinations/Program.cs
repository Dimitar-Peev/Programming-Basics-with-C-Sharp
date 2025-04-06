char ch1 = char.Parse(Console.ReadLine());
char ch2 = char.Parse(Console.ReadLine());
char ch3 = char.Parse(Console.ReadLine());

int counter = 0;

for (char i = ch1; i <= ch2; i++)
{
    for (char j = ch1; j <= ch2; j++)
    {
        for (char k = ch1; k <= ch2; k++)
        {
            if (i != ch3 && j != ch3 && k != ch3)
            {
                Console.Write($"{i}{j}{k} ");
                counter++;
            }
        }
    }
}

Console.WriteLine(counter);