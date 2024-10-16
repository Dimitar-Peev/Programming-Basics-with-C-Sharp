double celsius = double.Parse(Console.ReadLine());

if (celsius >= 26 && celsius <= 35)
{
    Console.WriteLine("Hot");
}
else if (celsius >= 20.1 && celsius <= 25.9)
{
    Console.WriteLine("Warm");
}
else if (celsius >= 15.00 && celsius <= 20.00)
{
    Console.WriteLine("Mild");
}
else if (celsius >= 12.00 && celsius <= 14.9)
{
    Console.WriteLine("Cool");
}
else if (celsius >= 5.00 && celsius <= 11.9)
{
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("unknown");
}