
//int number = 1;

//while (number <= 5)
//{
//    Console.WriteLine(number);
//    number++;
//}
//Console.WriteLine("\n\n\n");


Console.WriteLine("!!!Guess the Number!!!");
int numSecret = 7;
int guess = 0;
int guessCont = 1;

while (guess != numSecret && guessCont != 4)
{
    Console.Write($"{guessCont}. Guess Number (0-9): ");
    guess = int.Parse(Console.ReadLine());
    guessCont++;
    if (guess == numSecret)
    {
        Console.WriteLine("Congratulations");
        break;
    }
}
if (guess != numSecret)
{

    Console.WriteLine("Game over...");
}



