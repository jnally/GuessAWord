
using System;

namespace GuessAWord
{
    public class Word
    {
        private string word;
        private char[] hiddenWordState;

        public Word(string word)
        {
            this.word = word;
            hiddenWordState = new char[word.Length];
            Array.Fill(hiddenWordState, '*');
        }

        public string CheckHiddenWordState()
        {
            return new string(hiddenWordState);
        }

        public bool CheckLetter(char letter)
        {
            bool result = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (letter == word[i])
                {
                    result = true;
                    hiddenWordState[i] = letter;
                }
            }

            return result;
        }

        public bool IsSolved()
        {
            int totalStars = 0;

            for (int i = 0; i < hiddenWordState.Length; i++)
            {
                if (hiddenWordState[i] == '*')
                {
                    totalStars++;
                }
            }

            if (totalStars == 0)
            {
                return true;
            }
            return false;
        }
    }
}
