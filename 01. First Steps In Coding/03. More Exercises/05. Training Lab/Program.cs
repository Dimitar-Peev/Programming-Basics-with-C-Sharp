double w = double.Parse(Console.ReadLine()) * 100;
double h = double.Parse(Console.ReadLine()) * 100;

double freeSpaceW = Math.Floor(w / 120);
double freeSpaceH = Math.Floor((h - 100) / 70);
double countWorkSpace = (freeSpaceH * freeSpaceW) - 3;

Console.WriteLine($"{countWorkSpace:F0}");