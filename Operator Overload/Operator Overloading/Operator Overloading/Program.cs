using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Operator_Overloading
{
    internal class Program
    {
        int x, y, z;
        public Space(int a, int b, int c)
        {
            x = a;
            y = b;
            z = c;
        }
        public void display()
        {
            Console.Write("" + x );
            Console.Write("" + y);
            Console.Write("" + z);
            Console.WriteLine();
        }
        public static Space operator - (Space s)
        {
            s.x = -s.x;
            s.y = -s.y;
            s.z = -s.z;
        }
        class SpaceTest
        {
            public static void Main(string[] args)
            {
                Space s = new Space(10, -20, 30);
                Console.WriteLine("s:");
                s.display();

                -s:  // Activates the operator -() method
                
                Console.WriteLine("s:");
                s.display();

            }
        }
}
