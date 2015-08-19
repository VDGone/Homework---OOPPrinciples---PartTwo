namespace _01.Shapes
{
    using System;

    public class Square : Shape
    {
        

        public Square(double size)
            : base(size)
        {

        }

        public override double CalcSurface()
        {
            return this.Width * this.Width;
        }
    }
}
