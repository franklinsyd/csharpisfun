using System;

namespace ExampleOfInheritanceApplication
{
    class Shape
    {
        protected int width;
        protected int height;
        protected double radius;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }

        public void setRadius(double r)
        {
            radius = r;
        }

    }

    // Derived class
    class Rectangle : Shape  // This how you get a class to inherit from another class
    {
        public int getArea()
        {
            return (width * height);
        }
    }

    class Square : Shape
    {
        public int getArea()
        {
            return width * width;
        }
    }

    class Circle : Shape
    {
        public double getArea()
        {
            return 3.14 * radius * radius;
        }
    }
    class ShapeTester
    {
        static void Main(string[] args)
        {
            //Create a new rectangle
            Rectangle obj_rect = new Rectangle();
            obj_rect.setWidth(10);
            obj_rect.setHeight(25);

            //Create a new square
            Square obj_sqr = new Square();
            obj_sqr.setWidth(5);

            //Create a new circle
            Circle obj_circle = new Circle();
            obj_circle.setRadius(10);


            // Print the area of the Rectangle  and the square
            Console.WriteLine("The area of the Rectangle is: " + obj_rect.getArea());
            Console.WriteLine("The area of the Square is: " + obj_sqr.getArea());
            Console.WriteLine("The area of the Circle is: " + obj_circle.getArea());
            Console.ReadKey();
        }
    }
}
