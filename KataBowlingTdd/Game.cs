using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private int score = 0;
        public bool firstFrame = false;

        public int Score { get => score; set => score = value; }
        //public int ActualFrame { get { return actualFrame; } }

        public int AddRoll(int pins)
        {
            if (pins > maxScore)
                throw new ArgumentException("Die höchste Punktezahl ist 300!");
            if (pins < minScore)
                throw new ArgumentException("Die minimale Punktezahl ist 0!");

            //punkte ingesamt
            wurfen[actuelWurf++] = pins;

            //TODO to frame
            Score += pins;
            var sum = wurfen.Sum();
            return sum;
        }

        public int ActualWurf
        {
            get { return 1; }
        }

        //punkte, spare, strike
        public int Frame(int frame)
        {
            int ball = 0;
            int punkteIngesamt = 0;

            for (int i = 0; i < frame; i++)
            {
                //no strike no spare
                int ersteBall = wurfen[ball++];
                int zweiteBall = wurfen[ball++];
                int punktePro2Wurfe = ersteBall + zweiteBall;

                //spare
                if (punktePro2Wurfe == 10)
                {                    
                    punkteIngesamt += punktePro2Wurfe + wurfen[ball];
                }
                else
                {
                    punkteIngesamt += punktePro2Wurfe;
                }
            }
            return punkteIngesamt;
        }
    }
}
