using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Key in any number, please");
            double entryNumber = Convert.ToDouble(Console.ReadLine());
            double resultNumber = System.Math.Sqrt(entryNumber);
            Console.WriteLine("Square root of {0} is {1}", entryNumber, resultNumber);
            Console.ReadLine();
        }

        public static double SQRT(double x)
        {
            //YOUR CODE HERE: return the square root of x
            return 0;

        }
    }
}
