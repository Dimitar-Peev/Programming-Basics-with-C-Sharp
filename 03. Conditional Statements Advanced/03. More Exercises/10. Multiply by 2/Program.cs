while (true)
{
    double number = double.Parse(Console.ReadLine());
    if (number >= 0)
    {
        number *= 2;
    }
    else
    {
        Console.WriteLine("Negative number!");
        break;
    }

    Console.WriteLine($"Result: {number:F2}");
}