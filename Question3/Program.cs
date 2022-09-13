using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");

            string sentence = Console.ReadLine();

            string pigLatin = ToPigLatin(sentence);

            Console.WriteLine(pigLatin);

            Console.WriteLine("Enter a pigLatin sentence: ");

            string pigSentence = Console.ReadLine();

            string english = ToEnglish(pigSentence);

            Console.WriteLine(english);


        }

        public static string ToPigLatin(string sentence)
        {
            List<string> pigWords = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                pigWords.Add(word.Substring(1) + word.ElementAt(0) + "ay");
            }

            return string.Join(" ", pigWords);
        }

        public static string ToEnglish(string pigLatin)
        {
            List<string> englishWords = new List<string>();

            foreach (string word in pigLatin.Split(' '))
            {

               string newWord = word.Substring(0, word.Length - 2);
                englishWords.Add(newWord.ElementAt(newWord.Length - 1) + newWord.Substring(0, newWord.Length - 1));

            }
            return string.Join(" ", englishWords);


        }
    }
    }

