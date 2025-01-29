using MissionFour;

internal class Program
{
    private static void Main(string[] args)
    {   
        TicTacToe ttt = new TicTacToe();
        int turn = 0;
        char currentPlayer;
        Console.WriteLine("Welcome to Tic Tac Toe!");

        // Create a 3x3 array to represent the game board
        char[,] gameBoard = 
        {
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' } 
        };


        do
        {

            if (turn % 2 == 0) // Check if turn number is even
            {
                currentPlayer = 'X'; // Player 1 (X) plays on even turns
            }
            else
            {
                currentPlayer = 'O'; // Player 2 (O) plays on odd turns
            }

            Console.WriteLine("Player " + ((turn % 2) + 1) + ": Choose a number between 1 and 9 to place your " + currentPlayer);
            string userInput = Console.ReadLine(); // Read user input as string
            int userNumber;

            // Validate userInput
            if (!int.TryParse(userInput, out userNumber) || userNumber < 1 || userNumber > 9)
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 9.");
                continue;
            }

            // Correct position mapping
            int row = (userNumber - 1) / 3;
            int col = (userNumber - 1) % 3;

            if (gameBoard[row, col] == ' ')
            {
                gameBoard[row, col] = currentPlayer;
                Console.WriteLine("Player " + ((turn % 2) + 1) + " placed " + currentPlayer + " in postion " + userNumber + ".");
                turn++; //Switch players 

            }
            else
            {
                Console.WriteLine("That position is already taken!");
                continue; // Let the player repick a number 
            }

            ttt.PrintBoard(gameBoard);


        } while (turn < 9 && ttt.ReceiveBoard(gameBoard) == "No Winner yet...");

        Console.WriteLine(ttt.ReceiveBoard(gameBoard)); 

    }   
          
}
