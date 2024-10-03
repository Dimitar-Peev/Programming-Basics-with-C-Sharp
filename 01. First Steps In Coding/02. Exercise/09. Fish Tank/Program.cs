int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine()) / 100;

double liters = ((length * width * height) * 0.001) * (1 - percent);

Console.WriteLine(liters);