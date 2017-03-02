using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HU_L6_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // What if I don't know the amount of times the value will be entered?!

            Console.WriteLine("Please enter a number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num >= 0)
            {
                sum = sum + num; // Can also do sum += num 
                Console.WriteLine("Please enter a number");
                num = int.Parse(Console.ReadLine());
            }

            // Using Switch with string

            Console.WriteLine("Please enter a number");
            string theNumberA = (Console.ReadLine());

            switch (theNumberA)
            {
                case ("1"):
                    Console.WriteLine("Hello");
                    break;
                case ("2"):
                    Console.WriteLine("World");
                    break;
                case ("3"):
                    Console.WriteLine("David");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }

            // Using Switch with int

            Console.WriteLine("Please enter a number");
            int theNumberB = int.Parse(Console.ReadLine());

            switch (theNumberB)
            {
                case (1):
                    Console.WriteLine("Hello");
                    break;
                case (2):
                    Console.WriteLine("World");
                    break;
                case (3):
                    Console.WriteLine("David");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }

            // Array defined as 5
            int theSum = 0;
            int[] myIntArray = new int[5];

            for (int i = 0; i < myIntArray.Length; i++)
            {

                Console.WriteLine("Please enter a number");
                myIntArray[i] = int.Parse(Console.ReadLine());
                theSum = theSum + myIntArray[i];
            }
            Console.WriteLine("The sum is " + theSum);
            Console.WriteLine("The average is " + theSum / myIntArray.Length);

            // The user will defind the array length
            Console.WriteLine("Enter array length");
            int newArray = int.Parse(Console.ReadLine());

            int theSumB = 0;
            int[] myIntArrayUser = new int[newArray];

            for (int i = 0; i < myIntArray.Length; i++)
            {

                Console.WriteLine("Please enter a number");
                myIntArrayUser[i] = int.Parse(Console.ReadLine());
                theSumB = theSumB + myIntArrayUser[i];
            }
            Console.WriteLine("The sum is " + theSumB);
            Console.WriteLine("The average is " + theSumB / myIntArrayUser.Length);

        }

    }
}