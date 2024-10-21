string typeFigure = Console.ReadLine();

double area = 0;

if ("square".Equals(typeFigure))
{
    double side = double.Parse(Console.ReadLine());
    area = side * side;

}
else if ("rectangle".Equals(typeFigure))
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    area = a * b;

}
else if ("circle".Equals(typeFigure))
{
    double radius = double.Parse(Console.ReadLine());
    area = radius * radius * Math.PI;

}
else if ("triangle".Equals(typeFigure))
{
    double length = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());
    area = (length * height) / 2;

}
Console.WriteLine($"{area:F3}");