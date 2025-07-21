Console.WriteLine("Game start");


// Generate a random integer between x and y which is the target number
var randomInstance = new Random();
var targetNumber = randomInstance.Next(1, 101);

// Ask user to input a number again, repeat until numbers match
var isContinue = true;

do
{
    // Ask user to input a number
    Console.Write("Input a number: ");
    var userInput = Console.ReadLine();

    // Check if the user input is parsable to int
    var isParsable = int.TryParse(userInput, out var userInputNumber);

    if (isParsable)
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