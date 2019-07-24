using System;
using RockScissorsPaper.Models;

class Program
{
    private static int RandomNumber()
    {
        Random rnd = new Random();
    }
    
    private static void Main()
    {
        Console.WriteLine("YAY ROCK PAPER SCISSORS GAME!!");
        Console.WriteLine("Play rock paper scissors with me, your smart computer!");

        Console.Write("Rock, paper, scissors, shoot!: ");
        string userInput = Console.ReadLine();

        Random rnd = new Random();
        int rand = rnd.Next(0,3);

        Game newGame = new Game
    }
}
