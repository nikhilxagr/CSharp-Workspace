using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Sentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string word = "";

            Console.Write("Reversed sentence: ");

            // Start from last character
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                if (sentence[i] != ' ')
                {
                    word = sentence[i] + word;   // build word using charater
                }
                else
                {
                    Console.Write(word + " ");
                    word = "";
                }
            }
            // for Print first word
            Console.Write(word);
        }
    }
}