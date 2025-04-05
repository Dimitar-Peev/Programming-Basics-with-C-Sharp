int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

for (int currentNum = firstNum; currentNum <= secondNum; currentNum++)
{
    string currentNumAsString = currentNum.ToString();
    int evenNumsSum = 0;
    int oddNumsSum = 0;


    int length = currentNumAsString.Length;
    for (int digitPosition = 0; digitPosition < length; digitPosition++)
    {
        int currentDigit = int.Parse(currentNumAsString[digitPosition].ToString());

        if (digitPosition % 2 == 0)
        {
            evenNumsSum += currentDigit;
        }
        else
        {
            oddNumsSum += currentDigit;
        }
    }

    if (evenNumsSum == oddNumsSum)
    {
        Console.Write(currentNum + " ");
    }
}