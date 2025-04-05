int juryCount = int.Parse(Console.ReadLine());

int presentationsCount = 0;
double allGradesSum = 0;
double currentGradesSum = 0;
string presentationName = Console.ReadLine();

while (presentationName != "Finish")
{
    presentationsCount++;

    for (int i = 1; i <= juryCount; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        currentGradesSum += grade;
        allGradesSum += grade;
    }

    double averageGrade = currentGradesSum / juryCount;
    currentGradesSum = 0;

    Console.WriteLine($"{presentationName} - {averageGrade:f2}.");

    presentationName = Console.ReadLine();
}

double averageGradeAll = allGradesSum / (presentationsCount * juryCount);
Console.WriteLine($"Student's final assessment is {averageGradeAll:f2}.");