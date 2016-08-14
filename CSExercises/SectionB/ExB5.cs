using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
    // y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("For y=5x^2-4x+3\nKey in a number for X");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = (5 * System.Math.Pow(x, 2)) - (4 * x) + 3;
            Console.WriteLine("The value of y is {0}", y);
            Console.ReadLine();
        }
        /*Hi Hans, I don't understand the logic of the part below. While the code above works, I would like to know how to do it with
      two different Main() methods (or 'code of blocks??' Sorry, I'm still catching up on the jargons)
      Also, I think the table shows incorrect value for the output*/
        /*public static double CalculateY(double x)
        {
            //YOUR CODE HERE
            return 0;
        }*/
    }
}
