using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_of_Fortune
{
    class Puzzle
    {
        public List<char> wrongGuesses;
        public List<char> correctGuesses;

        public string phrase; 
        public Puzzle()
        {            
            wrongGuesses = new List<char>();
            correctGuesses = new List<char>();
            phrase = GeneratePuzzle();
        }

        public string GeneratePuzzle()
        {
            var words = new List<string> { "Leap", "apprenticeship", "Microsoft", "Jonathan" };
            Random rand = new Random();
            int index = rand.Next(words.Count);
            var word = words[index];
            words.RemoveAt(index);
            return word;
        }


        public string DisplayWordWithDashes()
        {

            StringBuilder sb = new StringBuilder(phrase.Length);

            for (int i = 0; i < phrase.Length; i++)
            {
                char currentChar = phrase[i];
                if (correctGuesses.Contains(currentChar))
                {
                    sb.Append(currentChar);

                }
                else
                {
                    sb.Append('-');
                }

            }
            return sb.ToString();
        }

        public bool IsComplete() 
        {
            foreach (char letter in phrase)
            {
                if  (!correctGuesses.Contains(letter))
                {
                    return false;
                }
            }
            return true;
        }

        public bool Guess()
        {
            Console.WriteLine("Enter a letter or word to guess:");
            var input = Console.ReadLine();
            if (input.Length > 1)
            {
                if(input== phrase)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(input.Length==1)
            {
                if(phrase.ToLower().Contains(input))
                {
                    correctGuesses.Add(input.ToLower()[0]);
                    return true;
                }
                else
                {
                    wrongGuesses.Add(input.ToLower()[0]);
                    return false;
                }
            }
            else
            {
                return false;
                // TODO: ADD VALIDATION HERE
            }
        }

        // TODO: Display method should display the work with the guessed letters replaced by low dashes ( _ )
        public void DisplayLetters()
        {

        }
    }
}
