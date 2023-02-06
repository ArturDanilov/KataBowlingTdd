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

        private int[] wurfen = new int[21];
        private int actuelWurf = 0;

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

            //punkte ingesamt
            Score += pins;

            wurfen[actuelWurf++] = pins;
            var sum = wurfen.Sum();

            return sum;
        }

        public int FrameScore(int actualWurf)
        {
            int ball = 0;
            int beideBallProWurf = 0;

            for (int i = 0; i < actualWurf; i++)
            {
                //no strike no spare
                int ersteBall = wurfen[ball++];
                int zweiteBall = wurfen[ball++];
                beideBallProWurf = ersteBall + zweiteBall;

                //spare
                if (wurfen[actualWurf] + wurfen[actualWurf + 1] == 10)
                {                    
                    return beideBallProWurf += wurfen[ball];
                }
            }
            return beideBallProWurf;
        }
    }
}
