using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBowlingTdd
{
    public class Frame
    {
        private int[] wurfen = new int[21];
        private int actualWurf = 0;

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
