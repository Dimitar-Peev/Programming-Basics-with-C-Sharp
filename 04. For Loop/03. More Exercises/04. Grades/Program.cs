int countStudents = int.Parse(Console.ReadLine());

double totalSum = 0;
int studenstWithExcellent = 0;
int studenstWithVeryGood = 0;
int studenstWithGood = 0;
int studenstWithFail = 0;

for (int i = 0; i < countStudents; i++)
{
    double grade = double.Parse(Console.ReadLine());
    totalSum += grade;

    if (grade >= 5)
    {
        studenstWithExcellent++;
    }
    else if (grade >= 4)
    {
        studenstWithVeryGood++;
    }
    else if (grade >= 3)
    {
        studenstWithGood++;
    }
    else if (grade >= 2)
    {
        studenstWithFail++;
    }
}

double averageGrade6 = studenstWithExcellent / (countStudents / 100.0);
Console.WriteLine($"Top students: {averageGrade6:F2}%");

double averageGrade5 = studenstWithVeryGood / (countStudents / 100.0);
Console.WriteLine($"Between 4.00 and 4.99: {averageGrade5:F2}%");

double averageGrade4 = studenstWithGood / (countStudents / 100.0);
Console.WriteLine($"Between 3.00 and 3.99: {averageGrade4:F2}%");

double averageGrade3 = studenstWithFail / (countStudents / 100.0);
Console.WriteLine($"Fail: {averageGrade3:F2}%");

double averageGrade = totalSum / countStudents;
Console.WriteLine($"Average: {averageGrade:F2}");