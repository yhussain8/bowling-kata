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
        private int strike = 0;
        private bool bonus = false;

        public void Roll(int pins)
        {
            rollNumber++;
            if (rollNumber > 20)
            {
                bonus = true;
            }
            else
            {
                score += pins;
                frameScore += pins;
            }
            if (strike > 0)
            {
                if (strike > 2)
                {
                    score += pins;
                    strike--;
                }
                score += pins;
                strike--;
            }
            if (pins == 10 && !bonus)
            {
                strike += 2;
                rollNumber++;
            }
            if (frameScore == 10 && strike < 2)
            {
                strike++;
            }
            if (rollNumber % 2 == 0)
            {
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