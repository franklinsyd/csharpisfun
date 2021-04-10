//Codes to see how delegate objects work
using System;
namespace OurOwnDelegate
{
    class TestOurOwnDelegate
    {
        //Declare some delegate functions
        public delegate void ConvertNumToEven(int num);
        public delegate void ConvertNumToOdd(int num);
        public delegate void Convert(int num);

        //Implement the functions

        public void ConvToOdd(int p)
        {
            Console.WriteLine("The orignal number is {0}", p);
            
            //Perform checks
            if(p%2==0)
            {
                p = p + 1; // p-1
                Console.WriteLine("The number has been converted to an odd number: {0}", p);

            }
            else
            {
                Console.WriteLine("The number is already an odd number: {0}", p);
            }

        }


        public void ConvToEven(int p)
        {
            Console.WriteLine("The orignal number is {0}", p);

            //Perform checks
            if (p % 2 != 0)
            {
                p = p + 1; // p-1
                Console.WriteLine("The number has been converted to an even number: {0}", p);

            }
            else
            {
                Console.WriteLine("The number is already an even number: {0}", p);
            }

        }

        //driver code
        public static void Main(String[] agrs)
        {
            //Lets declare some delegates to worth with and have some fun
            TestOurOwnDelegate obj_1 = new TestOurOwnDelegate();

            //Convert to odd
            Console.WriteLine("Please enter an integer you like: ");
            string var = Console.ReadLine();
            int var_number = Int32.Parse(var);

            //Declare a delegate object
            ConvertNumToOdd dlg_1 = new ConvertNumToOdd(obj_1.ConvToOdd);
            ConvertNumToEven dlg_2 = new ConvertNumToEven(obj_1.ConvToEven);

            //Run the delegates
            dlg_1(var_number);
            Console.WriteLine("============================================");
            dlg_2(var_number);

            Console.WriteLine("============================================");
            Convert dlg_3 = new Convert(obj_1.ConvToOdd); // ConvToOdd takes in one int parameter
            Convert dlg_4 = new Convert(obj_1.ConvToEven); // ConvToEven takes in one int parameter
            dlg_3(var_number);
            dlg_4(var_number);

        }

    }
}


