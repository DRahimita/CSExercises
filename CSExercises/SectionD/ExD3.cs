using System;

namespace CSExercises
{
    //Guess the Number Game: Write a C# program that would 
    //let you guess the number that the computer has in 
    //its “mind”.  Computer thinks of an integer between 0 and 9.

    //a.The program uses the random number function to first 
    //“think of” a number.It should then prompt you for a guess.  
    //If your guess is correct, then it would congratulate you 
    //and tell out how many attempts that you took to make the guess.  

    //b.Modify the program you wrote in 23(a) so that in addition 
    //to the basic guessing function, it would also say 
    //“You are a Wizard!” if you succeed in the first two attempts 
    //or say “You are a good guess” if you make it next three attempts 
    //else it would say “You are lousy!”  Every time you make a wrong guess, 
    //the program would prompt “Try again” and accept another guess.
    //The program repeats until you have made the correct guess.

    public class ExD3
    {
        public static void Main(string[] args)
        {
            Random guess = new Random();
            int numberIvy = guess.Next(1, 10); // creates a number between 1 and 9
            int numberUser;
            int attempt = 0;

            Console.WriteLine(numberIvy);

            do
            {
                Console.WriteLine("Guess what Ivy-the-Computer's number is:");
                numberUser = Convert.ToInt16(Console.ReadLine());

                if(numberIvy!=numberUser)
                {
                    Console.WriteLine("Wrong. Guess again");
                }
                else
                {
                    Console.WriteLine("Congratulations!After {0} attempt(s) you got the right number {1}",attempt,numberIvy);
                    if(attempt<3)
                    {
                        Console.WriteLine("You must be a wizard!");
                    }
                    else if(attempt>=3 && attempt<6)
                    {
                        Console.WriteLine("Good guess!");
                    }
                    else
                    {
                        Console.WriteLine("You're lousy!");
                    }
                }

                attempt=attempt+1; 
                //or attempt++;
            } 
            while (numberIvy != numberUser);
        }
    }
}
