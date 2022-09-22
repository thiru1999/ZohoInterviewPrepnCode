using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicast_delegates
{
    public delegate void rect_delegate(int x, int y);
    public class program
    {
        public void rect_area(int len,int breadth)
        {
            Console.WriteLine( (len * breadth));

        }
        public void rect_perimeter(int len, int breadth)
        {
                Console.WriteLine( 2*(len + breadth));

        }
    }

    public class program1
    {
        static void Main(string[] args)
        {
            int area;
            int perimeter;

            program p1 = new program();
            rect_delegate rd = new rect_delegate(p1.rect_area);
            rd += p1.rect_perimeter;
            rd(10, 20);
            rd(20, 30);
            rd(30, 40);




        }
    }
}
