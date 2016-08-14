using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Key in the coordinate for (X1,Y1)");
            Console.Write("X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Key in the coordinate for (X2,Y2)");
            Console.Write("X2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double output = System.Math.Sqrt(System.Math.Pow((x2-x1),2)+System.Math.Pow((y2-y1),2));/*tried using int, but Pow only recognizes double. Why?*/ 
            Console.WriteLine(output);
            Console.ReadLine();

        }

        /*Hi Hans, I don't understand the logic of the part below. While the code above works, I would like to know how to do it with
        two different Main() methods (or 'code of blocks??' Sorry, I'm still catching up on the jargons)*/
        /*public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE
            return 0;
        }*/
    }
}
