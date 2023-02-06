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
            Assert.That(_game.Roll(0), Is.EqualTo(0));
        }

        [Test]
        public void AddRoll_Eingabe1_Return1()
        {
            Assert.That(_game.Roll(1), Is.EqualTo(1));
        }

        [Test]
        public void AddRoll_Eingabe10_Return10()
        {
            Assert.That(_game.Roll(10), Is.EqualTo(10));
        }

        [Test]
        public void AddRoll_Eingabe20_Return20()
        {
            Assert.That(_game.Roll(20), Is.EqualTo(20));
        }

        [Test]
        public void AddRoll_Eingabe136_Return136()
        {
            Assert.That(_game.Roll(136), Is.EqualTo(136));
        }

        [Test]
        public void AddRoll_Eingabe300_Return300()
        {
            Assert.That(_game.Roll(300), Is.EqualTo(300));
        }

        [Test]
        public void AddRoll_Eingabe301_ReturnExeption()
        {
            var myExeption = Assert.Throws<ArgumentException>(() => _game.Roll(301));
            Assert.That(myExeption.Message, Is.EqualTo("Die höchste Punktezahl ist 300!"));
        }

        [Test]
        public void AddRoll_EingabeNegativeOne_ReturnExeption()
        {
            var myExeption = Assert.Throws<ArgumentException>(() => _game.Roll(-1));
            Assert.That(myExeption.Message, Is.EqualTo("Die minimale Punktezahl ist 0!"));
        }

        [Test]
        public void Score_Eingabe2Throws_ReturnSum2Throws()
        {
            _game.Roll(4);
            _game.Roll(5);

            Assert.That(_game.Score, Is.EqualTo(9));
        }

        [Test]
        public void FrameScore_Eingabe4Throws_ReturnScoreFor2Frame()
        {
            _game.Roll(4);
            _game.Roll(4);
            _game.Roll(2);
            _game.Roll(1);

            Assert.That(_game.FrameScore(1), Is.EqualTo(8));
            Assert.That(_game.FrameScore(2), Is.EqualTo(3));
        }

        [Test]
        public void FrameScore_Eingabe10Throws_ReturnScoreFor5Frame()
        {
            _game.Roll(1);
            _game.Roll(1);
            _game.Roll(2);
            _game.Roll(2);
            _game.Roll(3);
            _game.Roll(3);
            _game.Roll(4);
            _game.Roll(4);
            _game.Roll(5);
            _game.Roll(4);

            Assert.That(_game.FrameScore(1), Is.EqualTo(2));
            Assert.That(_game.FrameScore(2), Is.EqualTo(4));
            Assert.That(_game.FrameScore(3), Is.EqualTo(6));
            Assert.That(_game.FrameScore(4), Is.EqualTo(8));
            Assert.That(_game.FrameScore(5), Is.EqualTo(9));
        }

        [Test]
        public void FrameScore_EingaFurSpare3and7and3_Return13()
        {
            _game.Roll(3);
            _game.Roll(7);
            _game.Roll(3);

            Assert.That(_game.FrameScore(1), Is.EqualTo(13));
        }

        [Test]
        public void FrameScore_EingabeSpareAndNormalWurfe_ReturnCorrecteAusgabe()
        {
            _game.Roll(3);
            _game.Roll(7);
            _game.Roll(3);
            _game.Roll(2);

            Assert.That(_game.FrameScore(1), Is.EqualTo(13));
            Assert.That(_game.Score, Is.EqualTo(18));
        }
    }
}