using System;

//Syntax
/*
 * 
delegate (parameter_list) {
    // Code..
};

*/
namespace Anonymous_methods
{
    class Program
    {

        public delegate void say_something(string something); // one param
        public delegate double operation(double num_1, double num_2); // two params
        static void Main(string[] args)
        {
            Console.WriteLine("======== Implementation with 1 param =======");
            say_something greet = delegate(string word)
            {
                Console.WriteLine("{0} !!!", word);
            }; // to not forget to close

            greet("Bonjour, ca va?");
            greet("How are you ?");

            say_something smt_cool = delegate(string cool_words)
            {
                Console.WriteLine("{0} !!!", cool_words);
            }; // Do not forget to close

            smt_cool("Programming is fun");
            
            
            Console.WriteLine("======== Implementation with 2 params =======");

            operation mult = delegate(double n1, double n2)
            {
                /*
                * this method multiplies two numbers
                */
                return n1 * n2;
            };

            operation div = delegate (double n1, double n2)
            {
                /*
                 * this method divides two numbers
                 */
                if (n2==0)
                    return 0;   //making sure that we do not divide by zero
                return n1 / n2;
            };

            operation add = delegate (double n1, double n2)
            {
                /*
                 * this method adds two numbers
                 */
                return n1 + n2;
            };

            //Declare some dummy variables
            double n1 = 34.4;
            double n2 = 15.6;

            //Compute the results of each opertation => mult, div, add
            Console.WriteLine("The result of mult: {0}", mult(n1, n2));
            Console.WriteLine("The result of div: {0}", div(n1, n2));
            Console.WriteLine("The result of add: {0}", add(n1, n2));
        }
    }
}
