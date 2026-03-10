using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "";
            string reverse = "";

            Console.WriteLine("Enter a word to check Palindrom");
            word = Console.ReadLine();
            int length = word.Length;

            for (int i = length - 1; i >= 0; i--)
                {
                    reverse = reverse + word[i];
                }
            if (word == reverse)
            {
                Console.WriteLine("The word is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The word isn't a Palindrome.");
            }
        }
    }
}