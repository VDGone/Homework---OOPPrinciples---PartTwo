namespace _03.RangeExceptions
{
    using System;

    class RangeExceptionsMain
    {
        static void Main()
        {
            int[] sampleNumbers = { 12, 30, -1 ,1000 };

            foreach (int number in sampleNumbers)
            {
                try
                {
                    if (number < 0 || number > 100)
                    {
                        throw new InvalidRangeException<int>(0, 100);
                    }
                    Console.WriteLine("The given number \"{0}\" is in the allowed range", number);
                }
                catch (InvalidRangeException<int> ex)
                {
                    Console.WriteLine("{0} - {1}", number, ex.Message);
                }
            }

            Console.WriteLine();

            DateTime[] sampleDates = { new DateTime(1999, 3, 30), DateTime.Now }; 
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2015, 12, 31);

            foreach (DateTime date in sampleDates)
            {
                try
                {
                    if (date < startDate || date > endDate)
                    {
                        throw new InvalidRangeException<DateTime>(startDate, endDate);
                    }
                    Console.WriteLine(" The given date: {0:D} is in the allowed range", date);
                }
                catch (InvalidRangeException<DateTime> ex)
                {
                    Console.WriteLine("{0:D} - {1}", date, ex.Message);
                }
            }
        }
    }
}
