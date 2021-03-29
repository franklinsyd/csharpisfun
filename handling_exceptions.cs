using System;


//Syntax
/*
try
{
    // statements causing exception
}
catch (ExceptionName e1)
{
    // error handling code
}
catch (ExceptionName e2)
{
    // error handling code
}
catch (ExceptionName eN)
{
    // error handling code
}
finally
{
    // statements to be executed
}  */

namespace Exception_Handling
{
    class Division
    {
        int res; 

        Division()
        {
            res = 0;
        }
       public void divide(int num1, int num2)
       {

            try 
            {
                res = num1 / num2;
            }
            catch (DivideByZeroException  obj_except) 
            {
                Console.WriteLine("This is not cool {0}", obj_except);
                //This is where you log stuff in a log file or register
            }
            finally 
            {
                Console.WriteLine("The Quotient is: {0}", res);
            }


       }
        static void Main(string[] args)
        {
            Division obj_div = new Division();
            int numerator = 15;
            int denominator = 0;
            obj_div.divide(numerator, denominator);
            Console.ReadKey();
        }
    }
}
