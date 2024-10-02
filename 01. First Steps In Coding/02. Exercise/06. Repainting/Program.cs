int amountOfNylon = int.Parse(Console.ReadLine());
int amountOfPaint = int.Parse(Console.ReadLine());
int amountOfThinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double sumMaterials = ((amountOfNylon + 2) * 1.5) + ((amountOfPaint + (amountOfPaint * 0.1)) * 14.5) + (amountOfThinner * 5.00) + 0.4;
double sumWorkers = (sumMaterials * 0.3) * hours;
double totalSum = sumMaterials + sumWorkers;

Console.WriteLine(totalSum);