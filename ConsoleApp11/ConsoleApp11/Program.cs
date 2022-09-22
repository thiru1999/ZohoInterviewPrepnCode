/*using System;

public class Drawing
{
    public virtual double Area()
    {
        return 0;
    }
}

public class Circle : Drawing
{
    public double Radius { get; set; }
    public Circle()
    {
        Radius = 5;
    }
    public override double Area()
    {
        return (3.14) * Math.Pow(Radius, 2);
    }
    public double perimeter()
    {
        return 2;
    }
}

public class Square : Drawing
{
    public double Length { get; set; }
    public Square()
    {
        Length = 6;
    }
    public override double Area()
    {
        return Math.Pow(Length, 2);
    }
}

public class Rectangle : Drawing
{
    public double Height { get; set; }
    public double Width { get; set; }
    public Rectangle()
    {
        Height = 5.3;
        Width = 3.4;
    }
    public override double Area()
    {
        return Height * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Circle circle = new Circle();
        Console.WriteLine("Area :" + circle.Area());

        Drawing square = new Square();
        Console.WriteLine("Area :" + square.Area());

        Drawing rectangle = new Rectangle();
        Console.WriteLine("Area :" + rectangle.Area());
    }
}*/



using System;
namespace DAL
{
    public delegate void MyDelegate();
    class Program
    {
        public void CallerOne()
        {
            Console.WriteLine("This is Caller One function...");
        }
        public void CallerTwo()
        {
            Console.WriteLine("This is Caller Two function...");
        }
        public static void CallerThree()
        {
            Console.WriteLine("This is Caller Three function...");
        }
        static void Main()
        {
            //Create object of the class and give it an instance  
            Program p = new Program();
            //Crete the object of delegate and note that you have to pass the method as parameter. This is Single Cast  
            MyDelegate myDelegate = new MyDelegate(p.CallerOne);
            //Crete the object of delegate and note that you have to pass the method as parameter. This is Single Cast  
            MyDelegate myDelegate1 = new MyDelegate(p.CallerTwo);
            //Crete the object of delegate and note that you have to pass the method as parameter. This is Single Cast  
            MyDelegate myDelegate2 = new MyDelegate(CallerThree);
           /* myDelegate();
            myDelegate1();
            myDelegate2();*/
            //This Idea is Called Multi Cast  
            MyDelegate MyDelegate_MultiCast_Idea = myDelegate + myDelegate1 + myDelegate2;
            MyDelegate_MultiCast_Idea();
        }
    }
}