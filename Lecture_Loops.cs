// C# program to illustrate how looks work
using System;

class LoopsDemo
{
    public static void Main()
    {
        int x = 1; // initialize

        // Exit when x becomes greater than 4 
        while (x <= 10)
        {
            Console.WriteLine("Counter is: " + x);

            // Do not forget Increment the value of x for 
            // next iteration 
            x++;
        }

        Console.WriteLine("########## For loop equivalent below ######");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Counter is: " + i);

            if (i%2 == 0)
            {
                Console.WriteLine(i + "is an even number");
            }
            else
            {
                Console.WriteLine(i + "is an odd number");
            }
        }

        Console.WriteLine("########## Add some conditionals to your loop ######");

        for (int k = 1; k <= 10; k++)
        {
            if (k % 2 == 0) // if the reminder of the division by 2 is equal to 0
            {
                Console.WriteLine(k + " is an even number");
            }
            else
            {
                Console.WriteLine(k + " is an odd number");
            }
        }
    }
}