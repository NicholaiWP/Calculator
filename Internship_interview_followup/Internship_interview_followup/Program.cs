using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_interview_followup
{
    //Quick small program created by Nicholai West Pedersen for ability showcasing.
    //I also made some unit tests (MSTest) to prove these functions work as intended
    class Program
    {
        //Assignment Recreation and explanation
        static void Main(string[] args)
        {
            //function call
            Exercise();

            //Instantiates a new object by the name 'Calculator'.
            Calculator calc = new Calculator();

            Console.WriteLine("Add: " + calc.Addition(1, 1));
            Console.WriteLine("Add with more arguments: " + calc.Addition(10,10,10));
            Console.WriteLine("Subtract: " + calc.Subtract(10, 5));
            Console.WriteLine("Multiply: " + calc.Multiply(2, 5));
            Console.WriteLine("Division: " + calc.Division(81,9));
            Console.WriteLine("Modulus: " + calc.Modulus(9, 2));
            Console.WriteLine("SquareRoot: " + calc.SquareRoot(81));

            //test illegal output
            Console.WriteLine("SquareRoot: " + calc.SquareRoot(-81));

            Console.ReadLine();
        }

        //Test exercise from interview
        private static void Exercise()
        {
            //Variable declaration and initializing
            var someNumber = 9;
            var isFound = 1;

            //loop, keeps incremeting as long as 'i' is less than 100000.
            for (int i = 2; i < 100000; i++)
            {
                //Variable is used in if-statement. 'SomeNumber' is used with a modulus operator
                //-, compares with 'i' and returns a 'left-over' amount of the equation. e.g. 7 % 2 = 1.
                //As soon as a number is fully dividable and equals 0, the compiler will run the code
                //- of the if-statement's body.
                if (someNumber % i == 0)
                {
                    //Variable 'isFound' is used and assigned to 'i'.
                    isFound = i;
                    break;
                }

            }
            //Outputs the number '3' as 3 is dividable with 9. The if-statement's condition is fulfilled and
            //the divided number from the for-loop is then printed to the console window.
            Console.WriteLine("The number outputted was: " + isFound.ToString());
        }

    }
}
