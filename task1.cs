using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orangeC_1
{
    internal class task1
    {
        static void Main(string[] args)
        {
     //       string name;
     //       Console.WriteLine("please enter name");
     //       name = Console.ReadLine();
     //       Console.WriteLine(name);

     //       //2
     //       Console.WriteLine("please enter integer number");
     //       int num1 = Convert.ToInt32(Console.ReadLine());
     //       Console.WriteLine(num1);

     //       //3
     //       Console.WriteLine("please enter double number");
     //       double num2 = Convert.ToDouble(Console.ReadLine());
     //       Console.WriteLine(num2);

     //       //4
     //       Console.WriteLine("please enter char");
     //       char num3 = Convert.ToChar(Console.ReadLine());

     //       //5
     //       Console.WriteLine("please enter boolean");
     //       bool num4 = Convert.ToBoolean(Console.ReadLine());
     //       Console.ReadKey();

     //       //6 
     //       Console.WriteLine("this is constant");
     //       const int num5 = 5;
     //       Console.WriteLine(num5);

     //       //task2 array*******************************8
     //       string[] car = { "opel", "mercedes", "BMW" };
     //       for (int i = 0; i < car.Length; i++)
     //       {
     //           Console.WriteLine(car[i]);
     //       }


     //       //task 3 input name****************
     //       Console.WriteLine("please enter firstname");
     //       string firstname = Console.ReadLine();
     //       Console.WriteLine("please enter lastname");
     //       string lastname = Console.ReadLine();
     //       Console.WriteLine("please enter date of birth");
     //       int date = Convert.ToInt32(Console.ReadLine());
     //       Console.WriteLine(firstname + "" + lastname + "" + date);


     //       //task4 enter in array**********************
     //       int[] arrnum = new int[4];
     //       for (int i = 0; i < arrnum.Length; i++)
     //       {
     //           arrnum[i] = Convert.ToInt32(Console.ReadLine());
     //       }

     //       Console.WriteLine("\nElements in array are:");

     //       // Print elements of the array
     //       foreach (int num in arrnum)
     //       {
     //           Console.Write(num + " ");
     //       }


     //       //TASK5***************************888
     //       int[] arr2num = { 2, 5, 7, 8 };
     //       int count = 0;
     //       for (int i = 0; i < arr2num.Length; i++)
     //       {
     //           count += arr2num[i];
     //       }

     //       //type two of task ***********************************


     //       //task2-1 smaller number  ##########################3
     //       Console.WriteLine("please enter number1");
     //       int n1 = Convert.ToInt32(Console.ReadLine());
     //       Console.WriteLine("please enter numbe2");
     //       int n2 = Convert.ToInt32(Console.ReadLine());
     //       if (n1 > n2)
     //       {
     //           Console.WriteLine(n1);
     //       }
     //       else
     //       {
     //           Console.WriteLine(n2);
     //       }

     //       //task 2-2#####################################
     //       Console.WriteLine("please enter number1");
     //       int sigennum = Convert.ToInt32(Console.ReadLine());
     //       if (sigennum < 0)
     //       {
     //           Console.WriteLine("-");
     //       }
     //       else
     //       {
     //           Console.WriteLine("+");
     //       }

     //       //task 2-3#####################################3
     //       int[] myNumbers = { 5, 1, 8, 9 };
     //       Array.Sort(myNumbers);
     //       foreach (int i in myNumbers)
     //       {
     //           Console.WriteLine(i);
     //       }
     //       //task 2-4########################################

     //       int numb1 = -5, numb2 = -2, numb3 = -6, numb4 = 0, numb5 = -1;

     //       Console.WriteLine("Find the maximum using conditional statements");
     //       int max = num1;

     //       if (numb2 > max)
     //       {
     //           max = numb2;
     //       }

     //       if (num3 > max)
     //       {
     //           max = numb3;
     //       }

     //       if (numb4 > max)
     //       {
     //           max = numb4;
     //       }

     //       if (numb5 > max)
     //       {
     //           max = numb5;
     //       }


     //       Console.WriteLine($"Output: {max}");

     //       //task 2-5########################################

     //       Console.WriteLine("tranfear kilometer per hours to miles per houers");
     //       double kilometerperhouer = Convert.ToDouble(Console.ReadLine());
     //       Console.WriteLine("milesperperhouer:" + kilometerperhouer * 1, 8);


     //       //task 2-6########################################

     //       Console.WriteLine("tranfear hours to minutes");
     //       int houers = Convert.ToInt32(Console.ReadLine());
     //       int minutes = Convert.ToInt32(Console.ReadLine());
     //       int count1 = 0;
     //       count1 = (houers * 60) + minutes;
     //       Console.WriteLine("time in minute:" + (houers * 60) + minutes);

     //       //task 2-7########################################

     //       Console.Write("Enter minutes: ");
     //       int totalMinutes = Convert.ToInt32(Console.ReadLine());

     //       // Calculate hours and remaining minutes
     //       int hours1 = totalMinutes / 60;
     //       int minutes1 = totalMinutes % 60;

     //       // Display the result
     //       Console.WriteLine($"{hours1} Hours, {minutes1} Minutes");

     //       //tqask 2-8####################3333

     //       string[] sentences = new string[]
     //{
     //       "This is a short sentence.",
     //       "Today is a beautiful day.",
     //       "Programming is fun and challenging.",
     //       "The quick brown fox jumps over the lazy dog.",
     //       "Hello, world! Welcome to C# programming."
     //};

     //       // Print each sentence with fixed length
     //       Console.WriteLine("Sentences with fixed length:");
     //       foreach (string sentence in sentences)
     //       {
     //           // Fixed length to pad each sentence
     //           int fixedLength = 40;

     //           // Pad the sentence to fixed length using PadRight
     //           string paddedSentence = sentence.PadRight(fixedLength);

     //           // Print the padded sentence
     //           Console.WriteLine(paddedSentence);
     //       }

            //tqask 2-9####################3333

            string words = Console.ReadLine();
            
                for (int i = words.Length-1; i >= 0; i--)
                {
                    Console.Write(words[i]);

                }
                Console.WriteLine();

            
            
            //////
        }
    }
}
