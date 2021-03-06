using System;

namespace CSExercises
{
    //Use Euclid's Algorithm given below to determine 
    //the LCM and HCF for given two integer numbers.

    //- Take in as input two numbers A and B.

    //-	Subtract the smaller of the two numbers from 
    //  the Larger Number and assign the answer to the larger number.-->'assign the answer to the smaller number, not larger number

    //-	The above process is repeated until both the numbers are equal, say X.
    //-	Apparently the residual number (X) that we have obtained is the HCF.

    //-	LCM could then be computed using the formula(A* B)/HCF

    //-	Print out your answers.


    public class ExD2
    {
        public static void Main(string[] args)
        {
            int A, B, HCF, LCM;

            Console.Write("Enter the value of A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of B:");
            B = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                HCF = A%B;
                //Console.WriteLine(HCF);


            }
            else
            {
                HCF = B % A;
                //Console.WriteLine(HCF);

            }

            LCM = A * B / HCF;

            Console.WriteLine("Highest Common Factor for {0} and {1} is:{2}", A, B, HCF);
            Console.WriteLine("Lowest Common Multiple is:{0}", LCM);
        }
    }
}

