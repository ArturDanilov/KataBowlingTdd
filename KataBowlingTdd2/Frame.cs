namespace KataBowlingTdd2
{
    public class Frame 
    {
        public int[] PinsRolled;

        public int Score
        {
            get
            {
                int score = 0;

                foreach (int pin in PinsRolled)
                {
                    score += pin;
                }
                return score;
            }
        }
    }
}
