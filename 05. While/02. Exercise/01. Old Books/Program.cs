﻿string favoriteBook = Console.ReadLine();

int booksCount = 0;
bool isFound = false;
string breakCommand = "No More Books";

string input = Console.ReadLine();
while (input != breakCommand)
{
    if (input == favoriteBook)
    {
        isFound = true;
        break;
    }

    booksCount++;
    input = Console.ReadLine();
}

if (isFound)
{
    Console.WriteLine($"You checked {booksCount} books and found it.");
}
else
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {booksCount} books.");
}