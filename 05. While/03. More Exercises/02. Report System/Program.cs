int expectedAmount = int.Parse(Console.ReadLine());

int payment = 0;
int payWithCard = 0;
int payWithCash = 0;
double totalSumCard = 0;
double totalSumCash = 0;
int collectedAmount = 0;

string command = Console.ReadLine();
while (!command.Equals("End"))
{
    int price = int.Parse(command);
    payment++;

    if (payment % 2 != 0)
    {
        if (price > 100)
        {
            Console.WriteLine("Error in transaction!");
        }
        else
        {
            collectedAmount += price;
            totalSumCash += price;
            payWithCash++;
            Console.WriteLine("Product sold!");
        }
    }

    if (payment % 2 == 0)
    {
        if (price < 10)
        {
            Console.WriteLine("Error in transaction!");
        }
        else
        {
            collectedAmount += price;
            totalSumCard += price;
            payWithCard++;
            Console.WriteLine("Product sold!");
        }
    }

    if (collectedAmount >= expectedAmount)
    {
        Console.WriteLine($"Average CS: {(totalSumCash / payWithCash):F2}");
        Console.WriteLine($"Average CC: {(totalSumCard / payWithCard):F2}");
        return;
    }

    command = Console.ReadLine();
}

Console.WriteLine("Failed to collect required money for charity.");