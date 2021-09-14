using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class UserIOInput
    {
        
        public static char GetLetterFromUser()
        {

            string result;

            do
            {
                Console.Write("Please type a letter : ");
                result = Console.ReadLine();
            }
            while (result.Length != 1 || Char.IsLetter(result[0]) == false);
            return Char.ToLower(result[0]);
        }
    }
}
