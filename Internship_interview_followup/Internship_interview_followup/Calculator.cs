using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_interview_followup
{
    //Quick calculator class to demonstrate coding abilities. (Made in 10 minutes).
    public class Calculator
    {
        //Empty constructor
        public Calculator()
        {
        }

        //Adds a number to another number
        public int Addition(int arg0, int arg1)
        {
            int result = arg0 + arg1;
            return result;
        }

        //Function overloading.
        public int Addition(int arg0, int arg1, int arg2)
        {
            int result = arg0 + arg1 + arg2;
            return result;
        }

        //Subtracts a number from another number
        public int Subtract(int arg0, int arg1)
        {
            int result = arg0 - arg1;
            return result;
        }

        //Multiplies two numbers
        public int Multiply(int arg0, int arg1)
        {
            int result = arg0 * arg1;
            return result;
        }

        //Divides a number from another number
        public int Division(int arg0, int arg1)
        {
            int result = arg0 / arg1;
            if(arg1 <= 0)
            {
                throw new DivideByZeroException();
            }
            return result;
        }

        //Returns the left-over value or 0 if it's an equal number
        public int Modulus(int arg0, int arg1)
        {
            int result = arg0 % arg1;

           if(arg0 < arg1)
            {
              Console.WriteLine("Result will always be the value you modulus against, and in this case: " + result);
            }

            return result;
        }

        //Returns the square root of a number.
        public double SquareRoot(int arg0)
        {
            double result = Math.Sqrt(arg0);

            if (arg0 < 0)
            {
                Console.WriteLine("Illegal action, function can't take the square root of a negative number");
            }

            return result;
        }
    }
}
