using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        public void PrintBoard(char[] board)
        {
            Console.WriteLine();
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
            Console.WriteLine();

            return;

        }


        // Method that takes an array of characters and prints out if there is a winner yet of not...
        public string ReceiveBoard(char[] board)
        {
            // 2D Array of integers that contains winning patterns
            int[,] winningCombinations = new int[,]
            {
                {0, 1, 2}, {3, 4, 5} , {6, 7, 8} , // Row Combinations
                {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // Column Combinations
                {0, 4, 8}, {2, 4, 6} // Diagonal Combinations
            };

            // For loop that iterates through the winning combinations to see if they match the board combination
            for (int i = 0; i < winningCombinations.GetLength(0); i++)
            {
                int a = winningCombinations[i, 0];
                int b = winningCombinations[i, 1];
                int c = winningCombinations[i, 2];
                
                // if the winning combination is same as board combination, winner is defined
                if (board[a] == board[b] && board[b] == board[c] && board[a] != ' ')
                {
                    return $"Winner is {board[a]}";
                }
            }

            // otherwise there is not a winner yet...
            return "No Winner yet...";
        }


    }
}
    
