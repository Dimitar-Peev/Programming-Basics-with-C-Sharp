double dogFoodPrice = 2.50;
double catFoodPrice = 4.00;

int dogFoodPackages = int.Parse(Console.ReadLine());
int catFoodPackages = int.Parse(Console.ReadLine());

double totalSum = (dogFoodPrice * dogFoodPackages) + (catFoodPrice * catFoodPackages);

Console.WriteLine($"{totalSum} lv.");