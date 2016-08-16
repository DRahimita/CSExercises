using System;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges based on the kilometres travelled.

    //Minimum charge:  $2.40  (first 0.5 km no additional charges apply)
    //For the next 8.5 kms the rate is 4 cents for every 100 meters
    //After that:   5 cents for evey 100 meters

    //In the above example you should assume that the meter falls every 100 meters.So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:

    //$ 2.40 (first 0.5 km) +
    //$ 85 * 0.04 (next 8.5 km) +
    //$ (122 -90) * 0.05 (for distance over 9.0 km)
    //=  $7.40


    public class ExC4
    {
        public static void Main(string[] args)
        {

            //Your code here
            Console.Write("How far have you traveled (in km)?");
            double distance = Convert.ToDouble(Console.ReadLine());

            double fare = CalculateFare(distance);

            Console.WriteLine("You will need to pay ${0}", fare);
            Console.ReadKey();

        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            
            double fare;
            if (distance >= 0 && distance <= 0.5)
            {
                fare = 2.4;
            }
            else if (distance > 0.5 && distance <= 9)
            {
                fare = 2.4 + (Math.Ceiling((distance - 0.5) * 10)*1/ 10 * 10 * 0.04); //the 1/10*10* is a bit redundant, but I have to do it to show the relationship between '10 which is derived drom 1000m/100' and '1/10 from the rounding up which has to be multiplied with 1/10' 
            }
            else if (distance > 9)
            {
                fare = 2.4 + (8.5 * 10 * 0.04) + (Math.Ceiling((distance - 9) * 10)*1/10*10 * 0.05);//idem ditto
            }
            else
            {
                fare = 99999;
            }
        

            return fare;
          




        }
    }
}
