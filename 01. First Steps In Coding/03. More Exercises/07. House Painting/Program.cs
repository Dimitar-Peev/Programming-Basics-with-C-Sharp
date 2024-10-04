double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

double greenArea = 2 * (x * y) - 2 * (1.5 * 1.5) + 2 * (x * x) - 1.2 * 2;
double greenPaint = greenArea / 3.4;
double redArea = 2 * (x * y) + 2 * ((x * h) / 2);
double redPaint = redArea / 4.3;

Console.WriteLine($"{greenPaint:F2}");
Console.WriteLine($"{redPaint:F2}");