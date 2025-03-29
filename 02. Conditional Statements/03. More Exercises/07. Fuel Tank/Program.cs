string fuelType = Console.ReadLine();
int fuleQuantity = int.Parse(Console.ReadLine());
string outputMessage = "";

switch (fuelType)
{
    case "Diesel":
        if (fuleQuantity >= 25)
        {
            outputMessage = "You have enough diesel.";
        }
        else
        {
            outputMessage = "Fill your tank with diesel!";
        }
        break;
    case "Gasoline":
        if (fuleQuantity >= 25)
        {
            outputMessage = "You have enough gasoline.";
        }
        else
        {
            outputMessage = "Fill your tank with gasoline!";
        }
        break;
    case "Gas":
        if (fuleQuantity >= 25)
        {
            outputMessage = "You have enough gas.";
        }
        else
        {
            outputMessage = "Fill your tank with gas!";
        }
        break;
    default:
        outputMessage = "Invalid fuel!";
        break;

}

Console.WriteLine(outputMessage);