using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("How far have you traveled(in km)?");
            double input = Convert.ToDouble(Console.ReadLine());
            double output = 2.4 + input * 0.4;
            Console.WriteLine("Your taxi fare is ${0:###.#}", output);
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
