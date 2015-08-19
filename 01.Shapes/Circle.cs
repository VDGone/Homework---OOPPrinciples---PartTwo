namespace _01.Shapes
{
    using System;

    public class Circle : Shape
    {
        public Circle(double diameter)
            : base(diameter)
        {

        }

        public override double CalcSurface()
        {
            return Math.PI * Math.Pow(this.Width / 2.0, 2);
        }
    }
}
