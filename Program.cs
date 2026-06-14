// Jeremy Frank
// 06/13/2026
// Lab 5 - Mastermind

// Display a greeting and explain the game to the user.
Console.WriteLine("Welcome to Mastermind!");
Console.WriteLine();
Console.WriteLine("I have chosen 4 letters between 'a' and 'g'.");
Console.WriteLine("Your job is to guess the letters in the correct order.");
Console.WriteLine("The secret has no repeated letters.");
Console.WriteLine();

// This is the secret answer the user is trying to guess.
string secret = "fabc";

// This is where the user guess will be stored
string guess ="";

// this will count how many guesses
int guessCount = 0;

//Keep asking while the guess is not equal to the secret
do
{
    //this add a guess count to the guess. 
    guessCount = guessCount + 1;


    //Ask the user for a guess and display the guess count.
    Console.WriteLine("Guess #" + guessCount + ":");
    Console.Write("Please gues 4 letters with no repeats:");

    // The user's guess
    guess = Console.ReadLine () ??"";

// the loop will still keep going until the secret letter combination is entered.
}while (guess != secret);

// This only runs after the user guesses the secret.
Console.WriteLine();
Console.WriteLine("You did it! You guessed my secret: "+ secret + " after " + guessCount + " guesses! ");
