//int n = int.Parse(Console.ReadLine());

//for (int i = 0; i <= n + 1; i++)
//{
//    Console.Write(" ");
//}
//Console.WriteLine("|");


//for (int row = 1; row <= n; row++)
//{
//    for (int space = 1; space <= n - row + 1; space++)
//    {
//        Console.Write(" ");
//    }

//    for (int star = 1; star <= row; star++)
//    {
//        Console.Write("*");
//    }

//    Console.Write(" | ");

//    for (int star = 1; star <= row; star++)
//    {
//        Console.Write("*");
//    }

//    Console.WriteLine();
//}

int n = int.Parse(Console.ReadLine());

int spaces = n;
for (int i = 0; i <= n; i++)
{
    string line = "";

    // Добавяме интервалите
    for (int j = 0; j < spaces; j++)
    {
        line += " ";
    }

    // Добавяме звездите отляво
    for (int j = 0; j < i; j++)
    {
        line += "*";
    }

    // Добавяме разделителя
    line += " | ";

    // Добавяме звездите отдясно
    for (int j = 0; j < i; j++)
    {
        line += "*";
    }

    Console.WriteLine(line);
    spaces--;
}