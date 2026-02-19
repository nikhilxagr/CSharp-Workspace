using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Interfc
{
    interface Dog
    {
        void Bark();
    }
    interface Cat
    {
        void Meow();
    }

    class Animals : Dog, Cat
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
        public void Meow()
        {
            Console.WriteLine("Cat is meowing");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animals d = new Animals();
            d.Bark();
            d.Meow();
            Console.ReadLine();
        }
    }
}