// C# program to show the user defined exceptions
using System;
using System.IO;

// User defined Exception class
// Child of Exception
class DivByZeroException : Exception
{

    // Constructor
    public DivByZeroException()
    {
        Console.Write("You cannot devide by zero.");
    }

}

class LargeNumberException : Exception 
{

    // Constructor
    public LargeNumberException()
    {
        Console.Write("A large number exception was triggered.");

        //Generate UUID Code for the exception
        Guid exception_uuid = Guid.NewGuid();
        string exception_uuid_str = exception_uuid.ToString();
        Console.WriteLine("\nThe following log error was generated: {0}", exception_uuid_str);

        string file_name = "ErrorLog.txt";
        //Use your Own path here
        var path = @"C:\Users\sydne\Documents\Sydney\Varsity College\PROG6221\General\codes\UserDefinedException\" + file_name;

        //Get the current time
        DateTime exception_time = DateTime.Now;

        //Log information into a file.
        File.AppendAllText(path, "EXCEPTION-CODE: "+ exception_uuid_str+" at "+ exception_time.ToString() + "\n");

    }


}

class Program
{

    // Method to perform Division
    public double DivisionOperation(double numerator,
                                 double denominator)
    {
        // throw exception when denominator
        // value is 0
        if (denominator == 0)
            throw new DivByZeroException();

        //large number exception
        if (denominator > 10000 || numerator > 10000)
            throw new LargeNumberException();


        // Otherwise return the result of the division
        return numerator / denominator;
    }

    // Main
    static void Main(string[] args)
    {
        Program obj = new Program();
        //double num = 9, den = 200000, quotient;
        double num, den, quotient;

        Console.WriteLine("Enter the numerator:");
        num = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the denominator:");
        den = Convert.ToDouble(Console.ReadLine());

        try
        {
            // Code block that may cause an exception
            quotient = obj.DivisionOperation(num, den);
            Console.WriteLine("Quotient = {0}", quotient);
        }
        // Catch block to catch the generic exception
        catch (Exception e)
        {
            // Message property of exception object e
            // will give the specific type of the exception
            Console.Write(e.Message);
        }
    }
}