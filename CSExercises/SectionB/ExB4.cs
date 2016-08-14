using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature (in Celsius)?");
            double inputC = Convert.ToDouble(Console.ReadLine());
            double outputF = (1.8 * inputC) + 32;
            Console.WriteLine("The temperature is {0} Fahrenheit", outputF);
            Console.ReadLine();
        }
        
        /*Hi Hans, I don't understand the logic of the part below. While the code above works, I would like to know how to do it with
        two different Main() methods (or 'code of blocks??' Sorry, I'm still catching up on the jargons)*/

        /*public static double ConvertToFahrenheit(double c)
        {
            //YOUR CODE HERE - convert celcius to fahrenheit
            return 0;

        }*/
    }
}
