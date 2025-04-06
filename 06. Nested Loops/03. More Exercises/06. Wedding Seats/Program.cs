char lastSector = char.Parse(Console.ReadLine());
int rowsInFirstSector = int.Parse(Console.ReadLine());
int seatsOnOddRow = int.Parse(Console.ReadLine());

int totalSeats = 0;

for (char sector = 'A'; sector <= lastSector; sector++)
{
    int currentSectorRows = rowsInFirstSector + (sector - 'A');

    for (int row = 1; row <= currentSectorRows; row++)
    {
        int seats = row % 2 == 0 ? seatsOnOddRow + 2 : seatsOnOddRow;

        for (char seat = 'a'; seat < 'a' + seats; seat++)
        {
            Console.WriteLine($"{sector}{row}{seat}");
            totalSeats++;
        }
    }
}

Console.WriteLine(totalSeats);