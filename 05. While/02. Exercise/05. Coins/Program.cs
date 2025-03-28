//Input
double inputChange = double.Parse(Console.ReadLine());

double sum = Math.Round(inputChange * 100);
int coinsCounter = 0;

while (sum > 0)
{
    if (sum - 200 >= 0)
    {
        sum -= 200;
        coinsCounter++;
        continue;
    }
    else if (sum - 100 >= 0)
    {
        sum -= 100;
        coinsCounter++;
        continue;
    }
    else if (sum - 50 >= 0)
    {
        sum -= 50;
        coinsCounter++;
        continue;
    }
    else if (sum - 20 >= 0)
    {
        sum -= 20;
        coinsCounter++;
        continue;
    }
    else if (sum - 10 >= 0)
    {
        sum -= 10;
        coinsCounter++;
        continue;
    }
    else if (sum - 5 >= 0)
    {
        sum -= 5;
        coinsCounter++;
    }
    else if (sum - 2 >= 0)
    {
        sum -= 2;
        coinsCounter++;
        continue;
    }
    else if (sum - 1 >= 0)
    {
        sum -= 1;
        coinsCounter++;
        continue;
    }
}

//Output
Console.WriteLine(coinsCounter);