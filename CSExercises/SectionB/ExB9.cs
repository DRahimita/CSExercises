using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("How far have you traveled(in km)?");
            double input = Convert.ToDouble(Console.ReadLine());
            double fareTimesTen = (2.4 + input * 0.4)*10;
            double output = (System.Math.Ceiling(fareTimesTen))/10;
            Console.WriteLine("Your taxi fare is ${0:###.00}", output);
            Console.ReadLine();
        }

        /*Hi Hans, I don't understand the logic of the part below. While the code above works, I would like to know how to do it with
        two different Main() methods (or 'code of blocks??' Sorry, I'm still catching up on the jargons)*/


        /*public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            return 0;

        }*/
    }
}
