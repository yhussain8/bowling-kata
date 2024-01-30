using System;
using System.ComponentModel;
using System.Dynamic;
using System.Net;

namespace BowlingApp
{
    public class Game
    {
        private int score = 0;
        private int frameScore = 0;
        private bool newFrame = true;
        private bool spare = false;
        public void Roll(int pins)
        {
            score += pins;

            if (newFrame)
            {
                newFrame = false;
                frameScore += pins;
                if (spare)
                {
                    score += pins;
                    spare = false;
                }
            }
            else
            {
                newFrame = true;
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