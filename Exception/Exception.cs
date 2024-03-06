using System;

public class ExceptionsDemo
{
    public static void Main(string[] args)
    {
        try
        {


            // **Division by Zero:**
            int result = 15 / int.Parse("0");
            Console.WriteLine(result);


        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Division by zero error: {0}", e.Message);
        }
        try
        {
            // **Index Out of Range:**
            // This line will cause the IndexOutOfRangeException  
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[15]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Index out of range error: {0}", e.Message);
        }
    }
}