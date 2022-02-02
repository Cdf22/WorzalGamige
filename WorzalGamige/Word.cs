using System;
using System.Collections.Generic;
using System.Text;

namespace WorzalGamige
{
    public class Word
    {
        public bool Result { get; set; }
        List<Letter> Letters { get; set; }

        private string Name { get; set; }

        private string Answer { get; set; }

        public Word(string word, string answer)
        {
            Letters = new List<Letter>();

            Answer = answer;
            Name = word;
            int counter = 0;

            foreach (var letter in Name)
            {
                Letters.Add(new Letter(letter, counter++));
            }

            Check();
            Print();
        }

        private bool Check()
        {
            foreach (var letter in Letters)
            {
                letter.Check(Answer);
            }

            return true;
        }

        private void Print()
        {
            var count = 0;
            foreach (var l in Letters)
            {
                switch (l.ColourState)
                {
                    case Letter.State.A:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Letter.State.R:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Letter.State.G:
                        Console.ForegroundColor = ConsoleColor.Green;
                        count++;
                        break;
                    default:
                        break;
                }
                Console.Write(l.Name);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("");

            if(count == 5)
            {
                Result = true;
            }
        }
    }
}
