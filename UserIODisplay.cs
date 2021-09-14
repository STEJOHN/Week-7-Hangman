using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class UserIODisplay
    {

        public static void WelcomeMessage()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Welcome to Hangperson.");
            sb.AppendLine("\n\n\n");
            sb.AppendLine("To play, please enter any letter.");
            sb.AppendLine("Try to guess the word before running out of chances. ");

            Console.WriteLine(sb.ToString());
        }

        public static void PrintGameBoard(List<char> correctLetters, string word, int remainingGuesses, List<char> failedGuesses)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                if (correctLetters != null)
                {
                    if (correctLetters.Contains(word[i]))
                    {
                        sb.Append(word[i] + " ");
                    }
                    else
                    {
                        sb.Append("_ ");
                    }
                }
                else
                {
                    sb.Append("_ ");
                }
                
            }

            sb.Append("\t\tGuesses remaining: "+ remainingGuesses);
            sb.Append("\t\tGuessed letters: ");
            sb.AppendJoin(" ", failedGuesses);
            sb.AppendLine();
            Console.WriteLine(sb.ToString());

        }
    }
}
