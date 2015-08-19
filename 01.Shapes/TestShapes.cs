namespace _01.Shapes
{
    using System;

    //Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
    //Define two new classes Triangle and Rectangle that implement the virtual method and return the surface 
    //of the figure (height * width for rectangle and height * width/2 for triangle).
    //Define class Square and suitable constructor so that at initialization height must be kept equal
    //to width and implement the CalculateSurface() method.
    //Write a program that tests the behaviour of the CalculateSurface() method for different shapes 
    //(Square, Rectangle, Triangle) stored in an array.

    public class TestShapes
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[] 
            { 
                new Square (3), 
                new Circle (2), 
                new Rectangle (3, 4), 
                new Rectangle (3.5, 4.5),
                new Circle (3.5), 
                new Square (5.5), 
                new Square  (3), 
                new Triangle (4 , 5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Figure = {0} surface = {1:F2}",shape.GetType().Name.PadRight(10, ' '),shape.CalcSurface());
            }
        }
    }
}
