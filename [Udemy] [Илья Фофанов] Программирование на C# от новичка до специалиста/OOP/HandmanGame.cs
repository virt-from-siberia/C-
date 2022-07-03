using System;
using System.IO;

namespace OOP
{
    public class HandmanGame
    {
        private readonly int allowMisses;
        private bool[] openIndexes;
        private int triesCounter = 0;
        private string triedLetters;

        public GameStatus GameStatus { get; private set; } = GameStatus.NotStarted;

        public string Word { get; private set; }

        public string TriesLetters
        {
            get
            {
                var chars = triedLetters.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            }
        }

        public int RemaningTries
        {
            get { return allowMisses - triesCounter; }
        }

        public HandmanGame(int allowMisses = 8)
        {
            if (allowMisses < 5 || allowMisses > 8)
            {
                throw new AggregateException("Number of allowed misses should be between 5 and 8");
            }

            this.allowMisses = allowMisses;
        }

        public string GenerateWord()
        {
            string[] words = File.ReadAllLines("Handman/WordsStockRus.txt");
            Random r = new Random(DateTime.Now.Millisecond);
            int randomIndex = r.Next(words.Length - 1);

            Word = words[randomIndex];
            openIndexes = new bool[Word.Length];

            GameStatus = GameStatus.InProgress;
            return Word;
        }

        public string GuessLetter(char letter)
        {
            if (triesCounter == allowMisses)
                throw new InvalidOperationException($"Exceeded the max misses number {allowMisses}");

            if (GameStatus != GameStatus.InProgress)
                throw new InvalidOperationException($"Inaproppriate status if the game {GameStatus}");

            bool openAny = false;
            string result = string.Empty;

            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == letter)
                {
                    openIndexes[i] = true;
                    openAny = true;
                }

                if (openIndexes[i] == true)
                    result += Word[i];
                else
                    result += '-';
            }

            if (!openAny)
                triesCounter++;

            triedLetters += letter;

            if (isWin())
            {
                GameStatus = GameStatus.Won;
            }
            else if (triesCounter == allowMisses)
            {
                GameStatus = GameStatus.Lost;
            }

            return result;
        }

        private bool isWin()
        {
            foreach (var cur in openIndexes)
            {
                if (cur == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}