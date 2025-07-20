// See https://aka.ms/new-console-template for more information

Console.WriteLine("Game start");


// Generate a random integer between x and y which is the target number
var randomInstance = new Random();
var targetNumber = randomInstance.Next(1, 101);
// Ask user to input a number
Console.Write("Input a number: ");
var userInput = Console.ReadLine();
// Compare user input and target number
// Tell user if the input number is higher or lower than target number
// Ask user to input a number again, repeat until numbers match
// Winning message when the numbers are equal
 
 