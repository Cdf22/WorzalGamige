using System;
using System.Collections.Generic;
using System.Text;

namespace WorzalGamige
{
    public class Letter
    {
        public char Name { get; set; }
        int Position { get; set; }

        public State ColourState { get; set; } 

        public enum State 
        {
           A,R,G
        }

        public Letter(char c, int n)
        {
            Name = c;
            Position = n;
        }
        
        public void Check(string word)
        {
            if (word[Position] == Name)
            {
                ColourState = State.G;
                return;
            }

            if (word.Contains(Name))
            {
                ColourState = State.A;
                return;
            }

            ColourState = State.R;
            return;
        }
    }
}
