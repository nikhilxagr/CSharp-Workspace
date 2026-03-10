using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String_by_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Sentence:");
            string sentence = Console.ReadLine();

            int len = sentence.Length;
            string reverse = " ";

            //check the length of the sentence and reverse it by char

            for (int i = len - 1; i >= 0; i--)
            {
                reverse = reverse + sentence[i];
            }
            Console.WriteLine("Reversed Sentence :" + reverse);
        }
    }
}