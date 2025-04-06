int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int d1 = start; d1 <= end; d1++) 
{
    for (int d2 = start; d2 <= end; d2++) 
    {
        for (int d3 = start; d3 <= end; d3++) 
        {
            for (int d4 = start; d4 <= end; d4++) 
            {
                bool firstEven = d1 % 2 == 0;
                bool lastEven = d4 % 2 == 0;

                bool parityCondition = (firstEven && !lastEven) || (!firstEven && lastEven);
                bool firstGreaterThanLast = d1 > d4;
                bool middleSumEven = (d2 + d3) % 2 == 0;

                if (parityCondition && firstGreaterThanLast && middleSumEven)
                {
                    Console.Write($"{d1}{d2}{d3}{d4} ");
                }
            }
        }
    }
}

Console.WriteLine();