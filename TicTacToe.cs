using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//The supporting class (with whichever name you choose) will:
//• Receive the “board” array from the driver class
//• Contain a method that prints the board based on the information passed to it
//• Contain a method that receives the game board array as input and returns if there is a
//winner and who it was


namespace MissionFour
{
    internal class TicTacToe
    {


        // Method that takes an array of characters and prints out the board of X's and O's
        public void PrintBoard(char[,] board)
        {
            Console.WriteLine("\n  1 | 2 | 3 " + "         " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2]);
            Console.WriteLine("  ---------         ---------");
            Console.WriteLine("  4 | 5 | 6 " + "         " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2]);
            Console.WriteLine("  ---------         ---------");
            Console.WriteLine("  7 | 8 | 9 " + "         " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2] + "\n");
        }


        // Method that takes an array of characters and prints out if there is a winner yet of not...
        public string ReceiveBoard(char[,] board)
        {
            // Check rows for a winner
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return "Player " + board[i, 0] + " wins!";
                }
            }

            // Check columns for a winner
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    return "Player " + board[0, i] + " wins!";
                }
            }

            // Check the diagonal from top-left to bottom-right
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return "Player " + board[0, 0] + " wins!";
            }

            // Check the diagonal from top-right to bottom-left
            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return "Player " + board[0, 2] + " wins!";
            }

            // Check for a draw: If there's no empty space left, it's a draw
            bool isDraw = true;
            foreach (var cell in board)
            {
                if (cell == ' ') // If there's an empty space, it's not a draw
                {
                    isDraw = false;
                    break;
                }
            }

            if (isDraw)
            {
                return "It's a draw!";
            }

            // If no winner and not a draw, return this message
            return "No Winner yet...";
        }



    }
}
