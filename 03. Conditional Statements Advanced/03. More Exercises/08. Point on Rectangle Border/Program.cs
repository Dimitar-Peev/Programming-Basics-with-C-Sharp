double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());

bool border1 = (x == x1) && (y >= y1) && (y <= y2);
bool border2 = (x == x2) && (y >= y1) && (y <= y2);
bool border3 = (y == y1) && (x >= x1) && (x <= x2);
bool border4 = (y == y2) && (x >= x1) && (x <= x2);

if (border1 || border2 || border3 || border4)
{
    Console.WriteLine("Border");
}
else
{
    Console.WriteLine("Inside / Outside");
}