string studentName = Console.ReadLine();

int course = 0;
int fails = 0;
double sum = 0;

while (course < 12)
{
    double grade = double.Parse(Console.ReadLine());
    if (grade < 4)
    {
        if (fails == 1)
        {
            break;
        }

        fails++;
    }
    else
    {
        sum += grade;
        course++;
        fails = 0;
    }
}

if (course == 12)
{
    Console.WriteLine($"{studentName} graduated. Average grade: {sum / 12:f2}");
}
else
{
    Console.WriteLine($"{studentName} has been excluded at {course + 1} grade");
}