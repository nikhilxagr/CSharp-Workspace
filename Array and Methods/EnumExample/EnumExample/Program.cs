using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Area
    {
        public enum shape
        {
            circle,
            square,
        }

        public void AreaShape(int x, shape Shape)
        {
            double area;

            switch (Shape)
            {
                case shape.circle:
                    area = Math.PI * x * x;
                    Console.WriteLine("Circle Area " + area);
                    break;

                case shape.square:
                    area = x * x;
                    Console.WriteLine("Square Area " + area);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }

    class EnumTest
    {
        public static void Main()
        {
            Area area = new Area();

            area.AreaShape(15, Area.shape.circle);
            area.AreaShape(15, Area.shape.square);
            area.AreaShape(15, (Area.shape)1);
            area.AreaShape(15, (Area.shape)0);
            area.AreaShape(15, (Area.shape)10);
        }
    }
}