using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseA3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Key in an integer number");
            int Number = Convert.ToInt32(Console.ReadLine());
            int squareNumber = Number * Number;
            Console.WriteLine("{0} squared is {1}", Number, squareNumber);
            Console.ReadLine();
        }
        /*Hi Hans. I don't understand the code block below and the logic behind it. I have the same
         difficulties in Exercise A4. How do we use two Main() methods here?Is that allowed?*/

        /*public static int square(int x)
        {
            //PUT YOUR CODE HERE
            return 0;

        }*/
    }
}

