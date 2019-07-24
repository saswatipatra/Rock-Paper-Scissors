using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockScissorsPaper.Models;

namespace RockScissorsPaper.Tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void MethodName_Spec_ExpectedOutput()
        {
            Game instanceName = new Game();
            Assert.AreEqual(ExpectedOutput, instanceName.MethodName(inputHere));
        }
    }
}