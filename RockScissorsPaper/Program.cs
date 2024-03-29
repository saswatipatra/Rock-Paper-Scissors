using System;
using RockScissorsPaper.Models;

class Program
{
    private static void Main()
    {
        Console.WriteLine("YAY ROCK PAPER SCISSORS GAME!!");
        Console.WriteLine("Play rock paper scissors with me, your smart computer!");

        Console.Write("Rock, paper, scissors, shoot! (r/p/s): ");
        string userInput = Console.ReadLine();

        while (userInput != "r" && userInput != "p" && userInput != "s") {
            Console.WriteLine("Invalid input\n");
            Main();
        }

        Random rnd = new Random();
        int rand = rnd.Next(0,3);

        string computerMove = Game.numToMove[rand];

        Console.WriteLine($"\nYou: {Game.letterToMove[userInput]}\nComputer: {Game.letterToMove[computerMove]}");

        Game newGame = new Game(userInput, computerMove);

        if (newGame.DetermineDraw() == true)
        {
            Console.WriteLine("We have a draw.");
        }
        else
        {
            if (newGame.Player1_Win() == true)
            {
                Console.WriteLine("You won!\n");
            }
            else
            {
                Console.WriteLine("Computer won. :(\n");
            }
        }
        
        Main();
    }
}
