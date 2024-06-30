using System;

namespace yaser14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // task1*************

            int[] ARR = { 1, 7, 9, 45 };
            String[] arr2 = { "Str", "alex", "moh" };
            Console.WriteLine("Hello, World!");
            String[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            // task2*************
            //What the index of "Banana","Tomato" ?

            String[] fruits = ["Tomato", "Banana", "Watermelon"];
            //index of banna is :1
            //Index of Tomato is:0

            // task3*************
            string[] food = ["mansaf", "salat", "rice", "banana"];
            string[] sport = ["tenes", "hokey", "footbul"];
            string[] movies = ["game of throns", "attack on titan", "Iron man", "fast feoures"];
            foreach (string s in food)
            {
                Console.WriteLine(s);
            }
            foreach (string s in food)
            {
                Console.WriteLine(s);
            }
            foreach (string s in food)
            {
                Console.WriteLine(s);
            }

            // task4*************

            Console.Write("Input three numbers separated by comma: ");
            string input = Console.ReadLine();


            string[] parts = input.Split(',');
            int num1 = int.Parse(parts[0].Trim()); // Trim removes any leading or trailing whitespace
            int num2 = int.Parse(parts[1].Trim());
            int num3 = int.Parse(parts[2].Trim());


            int sum = num1 + num2 + num3;

            Console.WriteLine($"The sum of three numbers: {sum}.");
            // task5*************
            int count1 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    count1 += i;
                }
            }
            Console.WriteLine("the result is:" + count1);

            // task6*************
            for (int i = 0; i < 3; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            //task7***********

            for (int i = 0; i < 4; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("j");
                }
                Console.WriteLine("");
            }

            // new task*******************************************************************

            //new task 1************************
            int[] numbers = new int[10];

            Console.WriteLine("Input the 10 numbers:");


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number-{i + 1} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }


            int sum1 = 0;
            foreach (int num in numbers)
            {
                sum1 += num;
            }



            double average = (double)sum / 10;

            Console.WriteLine($"The sum of 10 numbers is : {sum}");
            Console.WriteLine($"The Average is : {average}");

            Console.ReadLine();


            //new task 2************************
            int numb1 = Convert.ToInt32(Console.ReadLine());
            int cube = 1;

            for (int i = 0; i < 3; i++)
            {
                cube = cube * numb1;
            }




            //new task 3************************
            //new task 4************************
            Console.WriteLine("enter your age");
            int agetoyear(int age)
            {
                return age * 365;
            }
            //new task 5************************

                int chickens = 2;
                int cows = 3;
                int pigs = 5;

                int totalLegs = CountLegs(chickens, cows, pigs);

                Console.WriteLine($"Total number of legs: {totalLegs}");
            }

            static int CountLegs(int chickens, int cows, int pigs)
            {
                if (chickens % 2 != 0 || cows % 2 != 0 || pigs % 2 != 0)
                {
                    throw new ArgumentException("All counts must be even numbers.");
                }

                
                int totalLegs = (chickens * 2) + (cows * 4) + (pigs * 4);
                return totalLegs;

            //new task 6************************

            string username = "user1";

            string password = "password123";

            string result = Login(username, password);

            Console.WriteLine($"Login result: {result}");
        }

        static string Login(string username, string password)
        {
            // Predefined list of valid users (username, password)
            (string, string)[] validUsers = {
            ("user1", "password123"),
            ("user2", "abcxyz"),
            ("admin", "admin@123")
        };

            // Check if the provided username and password match any valid user
            foreach (var user in validUsers)
            {
                if (user.Item1 == username && user.Item2 == password)
                {
                    return "pass";
                }
            }

            return "failed";

            // new task 7******************************************
            int baseNumber = 2;
            int exponent = 5;

            long result = CalculatePower(baseNumber, exponent);

           
        }

        static long CalculatePower(int baseNumber, int exponent)
        {
            if (exponent < 0)
            {
                throw new ArgumentException("Exponent must be non-negative for this implementation.");
            }

            long power = 1;
            for (int i = 0; i < exponent; i++)
            {
                power *= baseNumber;
            }

            return power;
            // new task 8****************************

            int year = 2000;

            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }

        static bool IsLeapYear(int year)
        {
            if (year < 1900 || year > 2024)
            {
                throw new ArgumentOutOfRangeException("Year must be between 1900 and 2024 inclusive.");
            }
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }

            //new task 9*******************************
            int number = 17;

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        static bool IsPrime(int number)
        {
           
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
            // new task 10*********************


            string sentence = "Hello, how are you doing today?";

            int wordCount = CountWords(sentence);

            Console.WriteLine($"Number of words in the sentence: {wordCount}");
        }

        static int CountWords(string sentence)
        {
          
            int count = 0;

    
            sentence = sentence.Trim();

   
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ' && (i == 0 || sentence[i - 1] == ' '))
                {
                    count++;
                }
            }

            return count;

            // vh task *****************************************************************

            //vh task1***************

            //vh task1***************
            //vh task1***************
            //vh task1***************
            //vh task1***************
        }
    }
}
