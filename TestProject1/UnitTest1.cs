using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BombermanMultiplayer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGame1()
        {
            Game game = new Game();
            Assert.AreNotEqual(game.world, null);
        }

        [TestMethod]
        public void TestMethodGame2()
        {
            Game game = new Game(0, 0);
            Assert.AreNotEqual(game.player1, null);
            Assert.AreNotEqual(game.player2, null);
        }

        [TestMethod]
        public void TestMethodGameOver0()
        {
            Game game = new Game(0, 0);
            game.player1.Dead = true;
            game.player2.Dead = true;
            game.GameOver();
            Assert.AreEqual(game.Winner, 0);
        }

        [TestMethod]
        public void TestMethodGameOver1()
        {
            Game game = new Game(0, 0);
            game.player1.Dead = true;
            game.player2.Dead = false;
            game.GameOver();
            Assert.AreEqual(game.Winner, 1);
        }

        [TestMethod]
        public void TestMethodGameOver2()
        {
            Game game = new Game(0, 0);
            game.player1.Dead = false;
            game.player2.Dead = true;
            game.GameOver();
            Assert.AreEqual(game.Winner, 2);
        }

        [TestMethod]
        public void TestMethodBombsLogic()
        {
            Game game = new Game(0, 0);
            game.BombsLogic();
            Assert.AreNotEqual(game.BombsOnTheMap, null);
        }
    }
}
