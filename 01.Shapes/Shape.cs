namespace _01.Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Shape(double size)
        {
            this.Width = size;
            this.Height = size;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be bigger than 0");
                }
                this.width = value;
            }
        }

        public double Height 
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be bigger than 0");
                }
                this.height = value;
            }
        }
        public virtual double CalcSurface()
        {
            return 0;
        }
    }
}
