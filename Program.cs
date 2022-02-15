/* This number guessing game was mostly coded at the Grand Circus C# workshop (2/2 and 2/3, 2022).
 * I made changes on 2/14: option to play or not, invalid/out of range guesses no longer count against you,
 * and phrasing.
 */

bool realInteger = false;
int userNumberGuess = 0;
Random rand = new Random(); //look this up later
int randomNumber = rand.Next(20) + 1;
bool correctGuess = false;
int numGuesses = 0;

Console.WriteLine("Hello, User!");
Console.WriteLine("Welcome to our number guessing game.");
Console.WriteLine();
Console.WriteLine("Would you like to play? y/n  ");

string playerChoice = Console.ReadLine();
if (playerChoice.ToLower() != "y")
{
    Console.WriteLine("Fair enough.");
}
else
{
    Console.WriteLine("Wonderful! We have chosen a number between 1 and 20.");
    while (correctGuess == false)
    {
        numGuesses++;
        Console.WriteLine();
        Console.Write("What is your guess?  ");

        string userInput = Console.ReadLine();
        realInteger = int.TryParse(userInput, out userNumberGuess);

        if (realInteger == false)
        {
            Console.WriteLine("That was not a valid guess.");
            numGuesses--;
        }
        else if (userNumberGuess > 20 || userNumberGuess < 1)
        {
            Console.WriteLine("That guess is out of range. Not to state the obvious, but:");
            numGuesses--;
        }


        if (userNumberGuess > randomNumber)
        {
            Console.WriteLine("Our number is lower than that.");
        }
        else if (userNumberGuess == randomNumber)
        {
            Console.WriteLine("You got it!");
            correctGuess = true;
        }
        else if (realInteger == true && userNumberGuess < randomNumber)
        {
            Console.WriteLine("Our number is higher than that.");
        }
    }
}


//Console.WriteLine(userNumberGuess + 10); //tests if userNumberGuess is int



if (numGuesses == 0)
{
    Console.WriteLine("It's not like we asked you to play Global Thermonuclear War...");
}
else if (numGuesses == 1)
{
    Console.WriteLine("Amazing! And you got it on the first guess.");
    Console.WriteLine();
    Console.WriteLine("Thanks for playing!");

}
else if (numGuesses < 4)
{
    Console.WriteLine($"Pretty good! You got it in {numGuesses} tries.");
    Console.WriteLine();
    Console.WriteLine("Thanks for playing!");

}
else
{
    Console.WriteLine($"You sure stuck with it. It took you {numGuesses} tries.");
    Console.WriteLine();
    Console.WriteLine("Thanks for playing!");

}


Console.WriteLine("Press 'Enter' to quit.");
Console.Read();