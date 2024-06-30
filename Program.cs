namespace yaser15
{
    internal class Program
    {
        //Task 1*******************
        public class MyClass
        {
            public MyClass()
            {
                Console.WriteLine("MyClass class has initialized!");
            }
        }
        //Task2******************
        public class Greeting
        {
            public void Introduce(string name)
            {
                Console.WriteLine($"Hello All, I am {name}");
            }
        }
        //Task3******************
        public class FactorialCalculator
        {
            public int CalculateFactorial(int n)
            {
                if (n < 0)
                    throw new ArgumentException("Factorial is not defined for negative numbers.");

                int result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        //Task4******************
        public class ArraySorter
        {
            public int[] SortArray(int[] array)
            {
                Array.Sort(array);
                return array;
            }
        }
        //Task5******************

        public class DateDifferenceCalculator
        {
            public void CalculateDateDifference(DateTime date1, DateTime date2)
            {
                TimeSpan difference = date2 - date1;
                int years = date2.Year - date1.Year;
                int months = date2.Month - date1.Month;
                int days = date2.Day - date1.Day;

                if (days < 0)
                {
                    months--;
                    days += DateTime.DaysInMonth(date1.Year, date1.Month);
                }
                if (months < 0)
                {
                    years--;
                    months += 12;
                }

                Console.WriteLine($"Difference: {years} years, {months} months, {days} days");
            }
        }

        //Task6******************
        public class StringToDateConverter
        {
            public void ConvertStringToDate(string dateString)
            {
                DateTime date = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
                Console.WriteLine($"Converted Date: {date.ToString("yyyy-MM-dd")}");
            }
        }

        static void Main(string[] args)
        {
           
        }
    }
}
