using KataBowlingTdd;

namespace KataBowlingTddTests
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
        public void AddRoll_Eingabe0_Return0()
        {
            Assert.That(_game.AddRoll(0), Is.EqualTo(0));
        }

        [Test]
        public void AddRoll_Eingabe1_Return1()
        {
            Assert.That(_game.AddRoll(1), Is.EqualTo(1));
        }

        [Test]
        public void AddRoll_Eingabe10_Return10()
        {
            Assert.That(_game.AddRoll(10), Is.EqualTo(10));
        }

        [Test]
        public void AddRoll_Eingabe20_Return20()
        {
            Assert.That(_game.AddRoll(20), Is.EqualTo(20));
        }

        [Test]
        public void AddRoll_Eingabe136_Return136()
        {
            Assert.That(_game.AddRoll(136), Is.EqualTo(136));
        }

        [Test]
        public void AddRoll_Eingabe300_Return300()
        {
            Assert.That(_game.AddRoll(300), Is.EqualTo(300));
        }

        [Test]
        public void AddRoll_Eingabe301_ReturnExeption()
        {
            var myExeption = Assert.Throws<ArgumentException>(() => _game.AddRoll(301));
            Assert.That(myExeption.Message, Is.EqualTo("Die höchste Punktezahl ist 300!"));
        }

        [Test]
        public void AddRoll_EingabeNegativeOne_ReturnExeption()
        {
            var myExeption = Assert.Throws<ArgumentException>(() => _game.AddRoll(-1));
            Assert.That(myExeption.Message, Is.EqualTo("Die minimale Punktezahl ist 0!"));
        }

        [Test]
        public void Score_Eingabe2Throws_ReturnSum2Throws()
        {
            _game.AddRoll(4);
            _game.AddRoll(5);

            Assert.That(_game.Score, Is.EqualTo(9));
        }

        [Test]
        public void FrameScore_Eingabe3_ReturnScore3AndActFrame1()
        {
            _game.AddRoll(3);

            Assert.That(_game.Score, Is.EqualTo(3));
            Assert.That(_game.ActualWurf, Is.EqualTo(1));
        }

        [Test]
        public void FrameScore_Eingabe3and5_Return8AndActFrame1()
        {
            _game.AddRoll(3);
            _game.AddRoll(5);

            Assert.That(_game.Score, Is.EqualTo(8));
            Assert.That(_game.ActualWurf, Is.EqualTo(1));
        }

        [Test]
        public void FrameScore_Einga1234_ReturnScore10AndFrames3And7()
        {
            _game.AddRoll(1);
            _game.AddRoll(2);
            _game.AddRoll(3);
            _game.AddRoll(4);

            Assert.That(_game.Score, Is.EqualTo(10));
            Assert.That(_game.Frame(1), Is.EqualTo(3));
            Assert.That(_game.Frame(2), Is.EqualTo(10));
            //Assert.That(_game.ActualWurf, Is.EqualTo(2));
        }
    }
}