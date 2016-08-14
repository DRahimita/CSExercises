using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges 
    //based on the kilometres travelled.
    //
    //Minimum fixed charge:  $2.40
    //In addition the fare would be computed at 40 cents per kilometer.
    //
    //E.g.If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4

    public class ExB7
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("How far have you traveled(in km)?");
            double input = Convert.ToDouble(Console.ReadLine());
            double output = 2.4 + input * 0.4;
            Console.WriteLine("Your taxi fare is ${0}",output);
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
