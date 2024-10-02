int chickenMenusCount = int.Parse(Console.ReadLine());  
int fishMenusCount = int.Parse(Console.ReadLine());  
int vegetarianMenusCount = int.Parse(Console.ReadLine());

double chickenMenusPrice = 10.35;
double fishMenusPrice = 12.40;
double vegetarianMenusPrice = 8.15;

double menusPrice = (chickenMenusCount * chickenMenusPrice) + (fishMenusCount * fishMenusPrice) + (vegetarianMenusCount * vegetarianMenusPrice);
double totalSum =  menusPrice + (menusPrice * 0.2) + 2.50;

Console.WriteLine(totalSum);
