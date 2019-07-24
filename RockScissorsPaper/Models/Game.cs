using System;
using System.Collections.Generic;

namespace RockScissorsPaper.Models
{
    public class Game
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public static Dictionary<int, string> numToMove = new Dictionary<int, string>() { {0, "r"}, {1, "p"}, {2, "s"} };
        public static Dictionary<string, string> letterToMove = new Dictionary<string, string>() { {"r", "Rock"}, {"p", "Paper"}, {"s", "Scissors"} };

        public Game(string player1, string player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public bool DetermineDraw()
        {
            if (Player1 == Player2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Player1_Win()
        {
            if (Player1=="r" && Player2=="s")
            {
                return true;
            }
            else if (Player1=="p" && Player2=="r")
            {
                return true;
            }
            else if (Player1=="s" && Player2=="p")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}