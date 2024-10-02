int pricePerYear = int.Parse(Console.ReadLine());

double shoesPrice = pricePerYear * 0.6;
double clothesPrice = shoesPrice * 0.8;
double ballPrice = clothesPrice / 4;
double accessoriesPrice = ballPrice / 5;

double totalPrice = pricePerYear + shoesPrice + clothesPrice + ballPrice + accessoriesPrice;

Console.WriteLine(totalPrice);