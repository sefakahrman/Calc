
try
{
    Console.WriteLine("**CalC**\n");
    Console.Write("Enter a number: ");
    int inputNumber1 = Int16.Parse(Console.ReadLine());
    Console.Write("\nSecond Number: ");
    int inputNumber2 = Int16.Parse(Console.ReadLine());
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
void plusMethod(int numberOne, int numberTwo)
{
    Console.WriteLine($"\n{numberOne} + {numberTwo} Result: " + (numberOne + numberTwo));
}
void minusMethod(int numberOne, int numberTwo)
{
    Console.WriteLine($"\n{numberOne} - {numberTwo} Result: " + (numberOne - numberTwo));
}
void multiplyMethod(int numberOne, int numberTwo)
{
    Console.WriteLine($"\n{numberOne} * {numberTwo} Result: " + numberOne * numberTwo);
}
void divideMethod(double numberOne, double numberTwo)
{
    Console.WriteLine($"\n{numberOne} / {numberTwo} Result: " + numberOne / numberTwo);
}