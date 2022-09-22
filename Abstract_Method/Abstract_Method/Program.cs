using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Method
{
    public abstract class Figure
    {
        public int width, height;
        public const float pi = 3.14f;
    
        public abstract int Getarea();


    }
    public class Triangle : Figure
    {
        public int radius;
        public Triangle(int r,int w,int h)
        {
            radius = r;
            width = w;
            height = h;

        }
      
        public override int Getarea()
        {
            return (int)pi * radius * radius * height;

        }



    }
    public class test
    {
        public static void Main()
        {
            Triangle f = new Triangle(20,10,20);
            Console.WriteLine(f.Getarea());
        }

    }
}
