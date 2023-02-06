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
            int beideBallProWurf = 0;

            for (int i = 0; i < actualWurf; i++)
            {
                //no strike no spare
                int ersteBall = wurfen[ball];
                int zweiteBall = wurfen[ball++];
                beideBallProWurf = ersteBall + zweiteBall;

                //spare
                if (wurfen[actualWurf] + wurfen[actualWurf + 1] == 10)
                {
                    return beideBallProWurf + wurfen[ball];
                }
            }
            return beideBallProWurf;
        }
    }
}
