using Plus_or_minus.Services;

Console.WriteLine("Game start");


// Call the target number generator method
var generatorService = new TargetNumberGeneratorService();
var targetNumber = generatorService.TargetNumberGenerator();
// Ask user to input a number again, repeat until numbers match
var isContinue = true;

do
{
    // Ask user to input a number
    Console.Write("Input a number: ");
    var userInput = Console.ReadLine();

    // Check if the user input is parsable to int, if not, tell user to input a number again
    if (int.TryParse(userInput, out var userInputNumber))
    {
        // Compare user input and target number
        // Tell user if the input number is higher or lower than target number
        // Winning message when the numbers are equal

        if (targetNumber > userInputNumber)
        {
            Console.WriteLine("Too low");
        }
        else if (targetNumber < userInputNumber)
        {
            Console.WriteLine("Too high");
        }
        else
        {
            Console.WriteLine("You win!");
            isContinue = false;
        }
    }

    else
    {
        Console.WriteLine("Invalid input, please write a number");
    }
} while (isContinue);