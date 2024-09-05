
try
{
    Console.WriteLine("**CalC**\n");
    Console.Write("Enter a number: ");
    int inputNumber1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nSecond Number: ");
    int inputNumber2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nEnter the Transaction You Want to Perform (* - / +) : ");
    string operationInput = Console.ReadLine();

    if (!(operationInput == ""))
    {
        if (operationInput == "*")
        {
            multiplyMethod(inputNumber1, inputNumber2);
        }
        else if (operationInput == "-")
        {
            minusMethod(inputNumber1, inputNumber2);
        }
        else if (operationInput == "+")
        {
            plusMethod(inputNumber1, inputNumber2);
        }
        else if (operationInput == "/")
        {
            divideMethod(inputNumber1, inputNumber2);
        }
        else
        {
            Console.WriteLine("The operation you selected is undefined...");
        }
    }
    else
    {
        Console.WriteLine("Empty value");
    }

}
catch (FormatException)
{
    Console.WriteLine("You entered a non-recommended value");
}


//Operations Methods
static void plusMethod(int numberOne, int numberTwo)
{
    Console.WriteLine($"\n{numberOne} + {numberTwo} Result: " + (numberOne + numberTwo));
}
static void minusMethod(int numberOne, int numberTwo)
{
    Console.WriteLine($"\n{numberOne} - {numberTwo} Result: " + (numberOne - numberTwo));
}
static void multiplyMethod(int numberOne, int numberTwo)
{
    Console.WriteLine($"\n{numberOne} * {numberTwo} Result: " + numberOne * numberTwo);
}
static void divideMethod(double numberOne, double numberTwo)
{
    Console.WriteLine($"\n{numberOne} / {numberTwo} Result: " + numberOne / numberTwo);
}