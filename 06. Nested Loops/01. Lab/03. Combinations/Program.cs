int n = int.Parse(Console.ReadLine());
int count = 0;

for (int first = 0; first <= n; first++)
{

    for (int second = 0; second <= n; second++)
    {

        for (int third = 0; third <= n; third++)
        {

            int sum = first + second + third;

            if (sum == n)
            {
                count++;
            }
        }
    }
}

Console.WriteLine(count);