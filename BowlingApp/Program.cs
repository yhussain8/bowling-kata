using System;
using System.ComponentModel;
using System.Dynamic;
using System.Net;

namespace BowlingApp
{
    public class Game
    {
        private int score = 0;
        private int rollNumber = 0;
        private int frameScore = 0;
        private bool spare = false;
        private bool bonus = false;

        public void Roll(int pins)
        {
            rollNumber++;
            score += pins;
            if (rollNumber > 20)
            {
                bonus = true;
            }
            if (rollNumber % 2 != 0)
            {
                frameScore += pins;
                if (spare && !bonus)
                {
                    score += pins;
                    spare = false;
                }
            }
            else
            {
                frameScore += pins;
                if (frameScore == 10)
                {
                    spare = true;
                }
                frameScore = 0;
            }
        }

        public int Score()
        {
            return  score;
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