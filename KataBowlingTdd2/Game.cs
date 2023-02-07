using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBowlingTdd2
{
    public class Game : IGame
    {
        Frame [] frames;

        public void AddRoll(int pins)
        {
            frames = new Frame[pins];
        }

        public Frame[] Frames()
        {
            return this.frames;
        }

        public bool Over()
        {
            throw new NotImplementedException();
        }

        public int TotalScore()
        {
            int score = 0;
            foreach (var frame in frames)
            {
                score+= frame.Score;
            }
            return score;
        }
    }
}
