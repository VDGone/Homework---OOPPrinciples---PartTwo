namespace _01.Shapes
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(double height, double width)
            : base(height, width)
        {
        }

        public override double CalcSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
