using System;

namespace CSExercises
{
    public class ExD1
    {
        public static void Main(string[] args)
        {

            int num;


            do
            {
                Console.Write("Enter a number:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num != 88)
                {
                    Console.WriteLine("Not your lucky day");
                }

            }
            while (num != 88);
            Console.WriteLine("Today's your lucky day!");
        }
    }

}
