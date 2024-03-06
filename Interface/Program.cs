using System;
public interface IResizable
{
    void ResizeWidth(int width1);
    void ResizeHeight(int height1);
}
/* It fully separates a class’ interface from its implementation by using the keyword interface.*/
/* Interfaces are syntactically similar to abstract classes. However, in an interface, no method can include a
body*/
/* Once an interface is defined, any number of classes can implement it. Also, one class can implement any
number of interfaces.*/
public class Rectangle : IResizable
{
    private int width;
    private int height;
    public Rectangle(int w, int h)
    {
        this.width = w;
        this.height = h;
    }
    public void ResizeWidth(int width1)
    {
        this.width = width1;
    }
    public void ResizeHeight(int height1)
    {
        this.height = height1;
    }
    public void PrintSize()
    {
        Console.WriteLine("Width={0} and Height={1}", this.width, this.height);
    }
}
public class Program12
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(100, 110);
        rectangle.PrintSize();
        rectangle.ResizeWidth(200);
        rectangle.ResizeHeight(200);
        rectangle.PrintSize();
    }
}