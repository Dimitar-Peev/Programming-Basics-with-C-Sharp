double depositSum  = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine()); 
double percentPerYear = double.Parse(Console.ReadLine()) / 100;

double totalSum = depositSum + months * ((depositSum * percentPerYear) / 12);

Console.WriteLine(totalSum);