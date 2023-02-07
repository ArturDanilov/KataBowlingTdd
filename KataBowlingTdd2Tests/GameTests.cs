using KataBowlingTdd2;

namespace KataBowlingTdd2Tests
{
    public class GameTests
    {
        Game _game;
        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }

        [TearDown]
        public void TearDown()
        {
            _game = null;
        }

        [Test]
        public void AddRoll_Eingabe1_ReturnPinsPolled1Score1()
        {
            //Arrange
            int pins = 1;

            //Act
             _game.AddRoll(pins);

            //Assert
            Assert.AreEqual(pins, _game.TotalScore());
        }

        //[Test]
        //public void AddRoll_Eingabe1_ReturnPinsFramesCount1()
        //{
        //    //Arrange
        //    int pins = 1;
        //    int expectedFramesCount = 1;
        //    //Act
        //    _game.AddRoll(pins);

        //    //Assert
        //    Assert.AreEqual(_game.Frames().Count(), expectedFramesCount);
        //}
    }
}