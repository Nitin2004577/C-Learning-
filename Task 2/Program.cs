using System;

namespace Workshop
{
    class Circle
    {
        public const double PI = 3.14;
        
        //radius
        private double radius;
        
        //constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }
        
        //area of circle
        public double Area()
        {
            return PI * Math.Pow(radius, 2);
        }
        
        //circumference of circle
        public double Perimeter()
        {
            return 2 * PI * radius;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Circle.PI = 2.14;
            //The error is that the PI is set as constant is becomes immutable so cannot be changed

            Circle circle = new Circle(4);
            
            Console.WriteLine($"The Area of the circle is {circle.Area()}");
            Console.WriteLine($"The Perimeter of the circle is {circle.Perimeter()}");

        }
    }
}