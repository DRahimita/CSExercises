using System;

namespace CSExercises
{
    //Write a program that would request for your name and gender (M or F assume capital letter) and print a greeting like this:
    //Good Morning Mr.Venkat
    //where you entered Venkat for name and M for gender.

    public class ExC1
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine();

            //YOUR CODE HERE
            if ((gender == "f")||(gender == "F"))
                Console.WriteLine("Good Morning Miss {0}", name);
            else if ((gender=="m")||(gender=="M"))
                Console.WriteLine("Good Morning Mr {0}", name);
            else
                Console.WriteLine("Mmmm... confused much, {0}?", name);

            Console.ReadKey();

        }
    }
}
