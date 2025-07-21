namespace Plus_or_minus.Services;

public class TargetNumberGeneratorService
{
    public int TargetNumberGenerator () {
    // Generate a random integer between x and y which is the target number
    var randomInstance = new Random();
    var targetNumber = randomInstance.Next(1, 101);
    return (targetNumber);
    }
}