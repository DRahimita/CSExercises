using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that will takes a double precision number as input 
    //and prints the square of that number
    //For this exercise, you need to implement the square function
    //and handle the input and output in the Main method (use Exercise 2 as an example)

    public class ExA4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            double entryNumber = Convert.ToDouble(Console.ReadLine());
            double resultNumber = entryNumber * entryNumber;

            Console.WriteLine("{0} to the power of 2 is {1}", entryNumber, resultNumber);
            Console.ReadLine();
        }
        /*Hi Hans, I don't understand the logic of the part below. While the code above works, I would like to know how to do it with
        two different Main() methods (or 'code of blocks??' Sorry, I'm still catching up on the jargons)*/ 
        
        /*public static double square(double x)
        {
            //PUT YOUR CODE HERE

            return 0;

        }*/
    }
}
