int hour = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

bool isClosed = hour < 10 || hour > 18 || ("Sunday").Equals(dayOfWeek);

if (isClosed)
{
    Console.WriteLine("closed");
}
else
{
    Console.WriteLine("open");
}