string input = Console.ReadLine();
int points = 0;

int length = input.Length;

for (int i = 0; i < length; i++)
{
    switch (input[i])
    {
        case 'a': points += 1; break;
        case 'e': points += 2; break;
        case 'i': points += 3; break;
        case 'o': points += 4; break;
        case 'u': points += 5; break;
    }
}

Console.WriteLine(points);