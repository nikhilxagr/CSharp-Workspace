using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imitals_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full name:");
            string fullName = Console.ReadLine();

            int len = fullName.Length;
            int spaceCount = 0;
            int lastSpaceIndex = 0;

            Console.Write(fullName[0] + ".");   // first name first character

            for (int i = 0; i < len; i++)
            {
                if (fullName[i] == ' ')
                {
                    spaceCount++;
                    lastSpaceIndex = i;

                    if (spaceCount == 1)   // only middle name first character
                    {
                        Console.Write(fullName[i + 1] + ".");
                    }
                }
            }

            Console.Write(" ");
            Console.WriteLine(fullName.Substring(lastSpaceIndex + 1));
        }
    }
}