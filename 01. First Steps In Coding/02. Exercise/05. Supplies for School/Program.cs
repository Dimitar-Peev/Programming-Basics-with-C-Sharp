double penPacketPrice = 5.80;
double markerPacketPrice = 7.20;
double cleanerLiterPrice = 1.20;

int penPacketCount = int.Parse(Console.ReadLine());
int markerPacketCount = int.Parse(Console.ReadLine());
int cleanerLitersCount = int.Parse(Console.ReadLine());
int percentDiscount = int.Parse(Console.ReadLine());

double sum = (penPacketCount * penPacketPrice) 
          + (markerPacketCount * markerPacketPrice) 
          + (cleanerLitersCount * cleanerLiterPrice);

double totalSum = sum - (sum * percentDiscount / 100);

Console.WriteLine(totalSum);