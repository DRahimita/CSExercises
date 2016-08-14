using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("We are going to determine the area of a triangle with a, b and c side.\nKey in length figures, please");
            Console.Write("a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double s = (a + b + c) / 2;

            double area = System.Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Area of the triangle is {0} unit(s)",area);

            Console.ReadLine();
        }
        /*Hi Hans, I don't understand the logic of the part below. While the code above works, I would like to know how to do it with
        two different Main() methods (or 'code of blocks??' Sorry, I'm still catching up on the jargons)*/


        /*public static double CalculateArea(double a, double b, double c)
        {
            //YOUR CODE HERE
            return 0;
        }*/
    }
}
