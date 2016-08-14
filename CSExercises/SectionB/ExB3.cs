using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Key in your salary in format XXXXXX \ne.g: Salary of $100,000 is to be keyed in as 100000");
            double salary = Convert.ToDouble(Console.ReadLine());
            double housingAllowance = 0.1 * salary;
            double transportAllowance = 0.03 * salary;
            double output = salary + housingAllowance + transportAllowance;
            Console.WriteLine("Your total package is ${0:#,##0.00}", output);
            Console.ReadLine();         
        }
        /*Hi Hans, I don't understand the logic of the part below. While the code above works, I would like to know how to do it with
        two different Main() methods (or 'code of blocks??' Sorry, I'm still catching up on the jargons)*/

        /*public static string CalculateIncome(string salaryStr)
        {
            //YOUR CODE HERE
            return null;
        }*/
    }
}
