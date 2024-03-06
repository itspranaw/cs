using System;
public abstract class Shape
{
    // Abstract methods to calculate area and perimeter
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}
/* a base class that defines only a generalized form that will be shared by all of its derived classes, leaving it to each
derived class to fill in the details.*/
// Here Shape is a base class but its methods are general and unimplemented . An abstract method is created by specifying
the abstract type modifier.
An abstract method contains no body and is, therefore, not implemented by the base class*/
/* an abstract method is automatically virtual, and there is no need to use the virtual modifier. In fact, it is an error to use
virtual and abstract together*/
// Derived class for a Circle
class Circle : Shape
{
    private double r;
    public Circle() { }
    public Circle(double r1)
    {
        r = r1;
    }
    public override double CalculateArea()
    {
        return Math.PI * r * r;
    }
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * r;
    }
}
/*Circle is a sub class which is derived from Shape and it has to give details for its
parent class abstract methods*/
// Derived class for a Rectangle
class Rectangle : Shape
{
    private double w, h;
    public Rectangle(double w1, double h1)
    {
        w = w1;
        h = h1;
    }
    public override double CalculateArea()
    {
        return w * h;
    }
    public override double CalculatePerimeter()
    {
        return 2 * (w + h);
    }
}
class Program1
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(5); //here circle is reference variable of
abstract class
Shape rectangle = new Rectangle(6, 4);
    // circle circle=new Circle(5) ; is also proper
    Console.WriteLine("Circle Area: " + circle.CalculateArea());
Console.WriteLine("Circle Perimeter: " + circle.CalculatePerimeter());
Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
Console.WriteLine("Rectangle Perimeter: " + rectangle.CalculatePerimeter());
Console.ReadKey();
}
}