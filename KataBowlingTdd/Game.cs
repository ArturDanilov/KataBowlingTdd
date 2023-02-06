using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBowlingTdd
{
    public class Game
    {
        public const int maxScore = 300;
        public const int minScore = 0;

        Frame frame = new Frame();
        private int[] wurfen = new int[21];
        private int actualWurf = 0;

        private int totalScore = 0;
        public int Score
        {
            get => totalScore;
            set => totalScore = value;
        }

        public int Roll(int pins)
        {

            if (pins > maxScore)
                throw new ArgumentException("Die höchste Punktezahl ist 300!");

            if (pins < minScore)
                throw new ArgumentException("Die minimale Punktezahl ist 0!");

            Score += pins;

            wurfen[actualWurf++] = pins;
            var sum = wurfen.Sum();

            return sum;
        }

        public int FrameScore(int actualWurf)
        {
            int result = 0;
            int ball = 0;
            int bothBall = 0;

            for (int i = 0; i < actualWurf; i++)
            {
                int firstBall = wurfen[ball++];
                int secondBall = wurfen[ball++];
                bothBall = firstBall + secondBall;

                if (wurfen[actualWurf] + wurfen[actualWurf + 1] == 10)
                {
                    result += bothBall + wurfen[ball];
                    return result;
                }
            }
            return bothBall;
        }
    }
}
