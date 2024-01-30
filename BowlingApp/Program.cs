using System;
using System.ComponentModel;
using System.Dynamic;
using System.Net;

namespace BowlingApp
{
    public class Game
    {
        private int _score = 0;
        public void Roll(int pins)
        {
            _score += pins;
        }

        public int Score()
        {
            return _score;
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