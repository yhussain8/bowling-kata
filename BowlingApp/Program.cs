namespace BowlingApp
{
    public class Game
    {
        private int score = 0;
        private int rollNumber = 0;
        private int frameScore = 0;
        private int bonus = 0;

        public void Roll(int pins)
        {
            if (bonus > 0)
            {
                if (bonus > 2)
                {
                    score += pins;
                    bonus--;
                }
                score += pins;
                bonus--;
            }
            rollNumber++;
            if (rollNumber < 21)
            {
                score += pins;
                frameScore += pins;
                if (pins == 10)
                {
                    bonus += 2;
                    rollNumber++;
                }
                else if (frameScore == 10)
                {
                    bonus++;
                }
                if (rollNumber % 2 == 0)
                {
                    frameScore = 0;
                }
            }
        }

        public int Score()
        {
            return score;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bowling Game Kata");
        }
    }
}