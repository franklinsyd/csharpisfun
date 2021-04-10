using System;

delegate int MultiplayByFatcor(int n);
delegate void ConvertToEven();
delegate void ConvertToOdd();

namespace OurOwnDelegate
{

    class TestOurOwnDelegate
    {
        static int num = 20;

        public static int mult(int k)
        {
            num = num * k;
            return num;
        }

        public static void ConvToOdd()
        {
            Console.WriteLine("The initial value is {0}", getNum());
            if (num%2 == 0)
            {
                num = num + 1;
                Console.WriteLine("The number has been converted to an odd number: {0}", getNum());
            }
            else
            {
                Console.WriteLine("The number is already odd: {0}", getNum());

            }
                

        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //Declare a Delegate Instance
            MultiplayByFatcor dlg_1 = new MultiplayByFatcor(mult);
            ConvertToOdd dlg_2 = new ConvertToOdd(ConvToOdd);

            //Call on a delgate method
            dlg_1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            
            //Run the second delegate
            dlg_2();

        }
    }
}