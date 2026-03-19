using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_EXL
{
    internal class Maruti
    {
        public virtual void Display()
        {
            Console.WriteLine("This is Maruti");
        }

    }
    class Esteem : Maruti
    {
        public override void Display()
        {
            Console.WriteLine("This is Esteem Maruti ");
        }
    }
    class Zen : Maruti
    {
        public override void Display()
        {
            Console.WriteLine("This is Zen Maruti");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Maruti m = new Maruti();
            m.Display();

            m = new Esteem();  // Upcasting
            m.Display();

            m = new Zen();   // Upcasting : Parent class reference can refer to child class object
            m.Display();
            Console.ReadLine();
        }
    }
}

//Output : 

//This is Maruti
//This is Esteem MAruti
//This is Zen Maruti
