using System;
using System.Collections.Generic;
using System.Text;

namespace WorzalGamige
{
    public class Game
    {
        List<Word> Words { get; set; }

        public Game()
        {
            Words = new List<Word>();
        }



        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Words.Clear();
            Console.WriteLine("Welcome to WorzalGamige. Enter a five-letter word");
        }

        public void Play()
        {
            var answers = new List<string>()
            {
                "booty",
                "sugar",
                "cigar",
                "dream",
                "realm",
                "whole",
                "holes",
                "moles",
                "mules",
                "roses",
                "those",
                "pingu"
            };

            var answer = answers[new Random().Next(0,11)];

            var gameWon = false;

            var wordInput = String.Empty;

            var tries = 0;
            while (!gameWon)
            {
                if (!GetWord(out wordInput))
                {
                    Console.WriteLine("Don't be a piss-ant!");
                    End(true);
                    return;
                }

                var newWord = new Word(wordInput, answer);
                Words.Add(newWord);

                if (newWord.Result)
                {
                    End(false);
                }

                tries++;

                if (tries == 6)
                {
                    End(true);
                }
            }
        }

        private void End(bool didTheyWin) 
        {
            if (didTheyWin)
            {
                Console.Clear();
                Console.WriteLine("Twat!. Come back when you are more grown-up");
            }
            else
            {
                Console.WriteLine("Well Done!");
            }
        }

        public bool CheckWord() 
        {
            return true;

        }

        public bool CheckResult() 
        {
            return true;
        }

        public bool GetWord(out string w) 
        {
            var newWord = Console.ReadLine();

            if(newWord.Length != 5)
            {
                w = "fuck you";
                return false;
            }

            w = newWord;
            return true;
        }
    }
}
