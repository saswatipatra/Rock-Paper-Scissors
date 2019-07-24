using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockScissorsPaper.Models;

namespace RockScissorsPaper.Tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void DetermineDraw_PlayersAreEqual_True()
        {
            Game newGame = new Game("rock", "rock");
            Assert.AreEqual(true, newGame.DetermineDraw());
        }

        [TestMethod]
        public void DetermineWin_Players1IsWinner_True()
        {
            Game newGame = new Game("r","p");
            Assert.AreEqual(false, newGame.Player1_Win());
        }
    }
}