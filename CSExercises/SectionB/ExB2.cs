using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Slight modification to above: Write a program that 
    //takes a double precision number as input and prints 
    //the square root of the number.  
    //The square root should be rounded to 3 decimal places.
    //Input	    Output
    //0	        0.000
    //25	    5       --->is this supposed to be 5.000?(3 decimal places)
    //3	        1.732
    //300	    17.321

    public class ExB2
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Key in any number, please");
            double entryNumber = Convert.ToDouble(Console.ReadLine());
            double resultNumber = System.Math.Sqrt(entryNumber);
            Console.WriteLine("Square root of {0} is {1:##0.000}", entryNumber, resultNumber);
            Console.ReadLine();
        }

        /*Sorry, I don't get the below part yet. Would you mind to tell us more. The above code works, but I would like to know 
        how to utilize the code block below*/
         
        /*public static string SQRT(double x)
        {
            //YOUR CODE HERE: return the square root of x and then use String.Format 
            //to format it. The format is similar to WriteLine
            return null;

        }*/

    }
}
