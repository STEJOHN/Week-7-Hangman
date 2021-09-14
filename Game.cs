using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
   public class Game
    {

        public int RemainingGuesses { get; set; }
        public List<char> CorrectGuesses { get; set; }
        public List<char> FailedGuesses { get; set; }
        public string Word { get; set; }

        public Game()
        {
            RemainingGuesses = 6;
            Word = RandomWord.Next(RandomWord.dictionary);
            CorrectGuesses = new List<char>();
            FailedGuesses = new List<char>();
        }

        public void Start()

        {
           
            
            UserIODisplay.WelcomeMessage();

            do
            {
                PrintGameBoard();

                char chosenChar = UserIOInput.GetLetterFromUser();

                if (Word.Contains(chosenChar) && CorrectGuesses.Contains(chosenChar) == false)
                {
                    CorrectGuesses.Add(chosenChar);
                    if (CheckIfWon())
                    {
                        Console.WriteLine("You won!!!");
                        break;
                    }
                } else
                {
                   if (FailedGuesses.Contains(chosenChar) == false && CorrectGuesses.Contains(chosenChar) == false)
                    {
                        FailedGuesses.Add(chosenChar);
                        RemainingGuesses--;
                    }
                    else
                    {
                        Console.WriteLine("\nThis letter was already selected.\n");
                    }
                }
            }
            while (RemainingGuesses > 0);

            if (RemainingGuesses == 0)
            {
                Console.WriteLine("Game over!");
            }

        }

        private void PrintGameBoard()
        {
            UserIODisplay.PrintGameBoard(CorrectGuesses, Word, RemainingGuesses, FailedGuesses);
        }

        private bool CheckIfWon()
        {
            for (int i = 0; i < Word.Length; i++)
            {
                if (CorrectGuesses.Contains(Word[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
