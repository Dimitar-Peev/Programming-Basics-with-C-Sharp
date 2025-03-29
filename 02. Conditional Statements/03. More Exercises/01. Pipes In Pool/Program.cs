int v = int.Parse(Console.ReadLine());
int p1 = int.Parse(Console.ReadLine());
int p2 = int.Parse(Console.ReadLine());
double hours = double.Parse(Console.ReadLine());

double pipe1 = p1 * hours;
double pipe2 = p2 * hours;
double sumWater = pipe1 + pipe2;

if (sumWater <= v)
{
    pipe1 = (pipe1 / sumWater) * 100;
    pipe2 = (pipe2 / sumWater) * 100;
    sumWater = (sumWater / v) * 100;
    Console.WriteLine($"The pool is {sumWater:F2}% full. Pipe 1: {pipe1:F2}%. Pipe 2: {pipe2:F2}%.");
}
else
{
    sumWater = sumWater - v;
    Console.WriteLine($"For {hours:F2} hours the pool overflows with {sumWater:F2} liters.", hours, sumWater);
}