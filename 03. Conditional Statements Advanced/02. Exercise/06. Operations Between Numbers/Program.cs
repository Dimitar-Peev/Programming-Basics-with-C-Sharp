int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());

double result = 0;
bool isEven = false;

switch (operation)
{
    case '+':
        result = a + b;
        isEven = result % 2 == 0;

        if (isEven)
        {
            Console.WriteLine($"{a} + {b} = {result} - even");
        }
        else
        {
            Console.WriteLine($"{a} + {b} = {result} - odd");
        }

        break;
    case '-':
        result = a - b;
        isEven = result % 2 == 0;

        if (isEven)
        {
            Console.WriteLine($"{a} - {b} = {result} - even");
        }
        else
        {
            Console.WriteLine($"{a} - {b} = {result} - odd");
        }

        break;
    case '*':
        result = a * b;
        isEven = result % 2 == 0;

        if (isEven)
        {
            Console.WriteLine($"{a} * {b} = {result} - even");
        }
        else
        {
            Console.WriteLine($"{a} * {b} = {result} - odd");
        }

        break;
    case '/':
        if (b == 0)
        {
            Console.WriteLine($"Cannot divide {a} by zero");
        }
        else
        {
            result = a / (b * 1.0);
            Console.WriteLine($"{a} / {b} = {result:F2}");
        }
        break;

    case '%':
        if (b == 0)
        {
            Console.WriteLine($"Cannot divide {a} by zero");
        }
        else
        {
            result = a % b;
            Console.WriteLine($"{a} % {b} = {result}");
        }
        break;
}