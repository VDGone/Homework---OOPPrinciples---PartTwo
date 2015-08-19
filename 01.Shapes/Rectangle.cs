namespace _01.Shapes
{
    using System;

    public class Rectangle : Shape
    {
        public Rectangle(double widht, double height)
            : base(widht, height)
        {

        }
        public override double CalcSurface()
        {
            return this.Width * this.Height;
        }
    }
}
