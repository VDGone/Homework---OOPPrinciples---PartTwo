namespace _03.RangeExceptions
{
    using System;

    class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(T start, T end)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get
            { 
                return this.start; 
            }
            set 
            {
                start = value; 
            }
        }

        public T End
        {
            get 
            { 
                return this.end; 
            }
            set 
            { 
                end = value; 
            }
        }

        public override string Message
        {
            get
            {
                return string.Format("The given number: {0} is out of the allowed range [{1}, {2}]",
                    typeof(T).Name, this.Start, this.End);
            }
        }
    }
}
