using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Numbers
    {
        private int[] arr = new int[5];

        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Numbers n = new Numbers();

            n[0] = 10;
            n[1] = 20;
            n[2] = 30;
            n[3] = 40;
            n[4] = 50;

            Console.WriteLine("Values :");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.ReadLine();
        }
    }
}