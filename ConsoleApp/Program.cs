using System.Runtime.CompilerServices;

Console.WriteLine("Welcome to the Rock, Paper, Scissors Game! by EA\n");

while (true)
{
    Console.WriteLine("Are you ready to test your wits against the computer?\n");
    Console.WriteLine("Choose your weapon wisely and see if you can outsmart your opponent.\n");

    var selectedChoice = SelectChoice();
    var yourchoice = char.Parse(selectedChoice);

    Console.WriteLine($"Your choice: {yourchoice}\n");

    var opponentChoice = GetOpponentChoice();

    Console.WriteLine($"Computer choose: {opponentChoice}\n");

    decideWinner(opponentChoice, yourchoice);

    Console.WriteLine("Do you want to continue?\n");
    Console.WriteLine("Type 'Y' to continue, or any other key to stop.\n");
    var playAgain = Console.ReadLine();
    if (playAgain?.ToLower() == "y")
        continue;
    else
        break;
}

string SelectChoice()
{
    Console.WriteLine("Instructions:\n- Type 'R' for Rock\n- Type 'P' for Paper\n- Type 'S' for Scissors\n");

    var selectedChoice = Console.ReadLine()?.ToLower();

    if (selectedChoice?.ToLower() != "r" && selectedChoice?.ToLower() != "p" && selectedChoice?.ToLower() != "s")
    {
        Console.WriteLine("^ Invalid input. Please enter only one letter.");
        selectedChoice = SelectChoice();
    }
    return selectedChoice;
}

char GetOpponentChoice()
{
    char[] options = new char[] { 'r', 'p', 's' };
    Random random = new Random();
    int randomIndex = random.Next(0, options.Length);

    return options[randomIndex];
}

void decideWinner(char opponentChoice, char yourchoice)
{
    if (opponentChoice == yourchoice)
    {
        Console.WriteLine("It's a tie!\n\n");
        return;
    }

    switch (yourchoice)
    {
        case 'R':
        case 'r':
            if (opponentChoice == 'P')
                Console.WriteLine("Paper beats rock. You lose!");
            else if (opponentChoice == 'S')
                Console.WriteLine("Rock beats scissors. You win!");
            break;

        case 'S':
        case 's':
            if (opponentChoice == 'P')
                Console.WriteLine("Scissors beats paper. You win!");
            else if (opponentChoice == 'R')
                Console.WriteLine("Rock beats scissors. You lose!");
            break;

        case 'P':
        case 'p':
            if (opponentChoice == 'S')
                Console.WriteLine("Scissors beats paper. You lose!");
            else if (opponentChoice == 'R')
                Console.WriteLine("Paper beats rock. You win!");
            break;

        default:
            break;
    }

}
