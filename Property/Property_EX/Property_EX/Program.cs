using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_EX
{
    internal class Program
    {
        private int x;
        private int y;
        public int setx
        {
            get { return x; 
            }
            set { x = value;
            }
        }
        public int sety
        {
            get { return y; }
            set { y = value; }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.setx = 10;
            p.sety = 20;
            Console.WriteLine("x: " + p.setx);
            Console.WriteLine("y: " + p.sety);
            Console.ReadLine();
        }
    }
}